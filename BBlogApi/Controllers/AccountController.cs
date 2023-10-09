using AutoMapper;
using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Helpers;
using BBlogApi.Models;
using BBlogApi.Repository.IRepository;
using BBlogApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BBlogApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<Account> _userManager;
		private readonly IMapper _mapper;
		private readonly TokenService _tokenService;

		public AccountController(UserManager<Account> userManager, IMapper mapper, TokenService tokenService)
		{
			_userManager = userManager;
			_mapper = mapper;
			_tokenService = tokenService;
		}

		[HttpGet("CurrentUser")]
		public async Task<ActionResult> CurrentUser()
		{
			var user = await _userManager.Users.ToListAsync();
			return Ok(user);
		}

		[HttpPost("Register")]
		public async Task<ActionResult> Register(RegisterDto registerDto)
		{
			try
			{
				var userExists = await _userManager.FindByNameAsync(registerDto.Email);
				if (userExists != null)
					return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

				var user = new Account
				{
					Email = registerDto.Email,
					UserName = registerDto.Email,
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
					UserName = user.Email,
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
