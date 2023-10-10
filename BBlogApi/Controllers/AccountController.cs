using AutoMapper;
using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Extensions;
using BBlogApi.Helpers;
using BBlogApi.Models;
using BBlogApi.Repository.IRepository;
using BBlogApi.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BBlogApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<Account> _userManager;
		private readonly IMapper _mapper;
		private readonly TokenService _tokenService;
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly BlogContext _blogContext;

		public AccountController(UserManager<Account> userManager, IMapper mapper, TokenService tokenService, IHttpContextAccessor httpContextAccessor, BlogContext blogContext)
		{
			_userManager = userManager;
			_mapper = mapper;
			_tokenService = tokenService;
			_httpContextAccessor = httpContextAccessor;
			_blogContext = blogContext;
		}

		[HttpGet("GetAllUser")]
		public async Task<ActionResult> GetAllUser()
		{
			var user = await _userManager.Users.ToListAsync();
			return Ok(user);
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Member")]
		[HttpGet("CurrentUser")]
		public async Task<ActionResult> CurrentUser()
		{
			try
			{
				System.Security.Claims.ClaimsPrincipal currentUser = this.User;
				bool isAdmin = currentUser.IsInRole("Member");
				string? userId = _userManager.GetUserId(User); // Get user id:
													   //var user = User.FindFirstValue(ClaimTypes.NameIdentifier);

				//var userId = Convert.ToInt32(HttpContext.User.FindFirstValue("id"));
				if (userId == null) return Unauthorized();

				return Ok(userId);
			} catch
			{
				return BadRequest();
			}
		}

		[HttpPost("Register")]
		public async Task<ActionResult> Register(RegisterDto registerDto)
		{
			try
			{
				var userExists = await _userManager.FindByEmailAsync(registerDto.Email);
				if (userExists != null)
					return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

				var user = new Account
				{
					UserName = registerDto.Email,
					Email = registerDto.Email,
					MemberName = registerDto.MemberName
				};

				var result = await _userManager.CreateAsync(user, registerDto.Password);
				if (!result.Succeeded)
					return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

				if (result.Succeeded) await _userManager.AddToRoleAsync(user, "Member");

				return Ok(new Response { Status = "Success", Message = "User created successfully!" });

			} catch (Exception ex)
			{
				return BadRequest();
			}

		}

		[HttpPost("Login")]
		public async Task<ActionResult<AccountDto>> Login(LoginDto loginDto)
		{
			try
			{
				var user = await _userManager.FindByNameAsync(loginDto.Email);
				if (user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password))
				{
					return Unauthorized();
				}

				return new AccountDto
				{
					UserName = user.UserName,
					Email = user.Email,
					Token = await _tokenService.GenerateToken(user)
				};
			} catch
			{
				return BadRequest();
			}
			
		}
    }
}
