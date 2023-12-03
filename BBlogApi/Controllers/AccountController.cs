using AutoMapper;
using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Helpers;
using BBlogApi.Models;
using BBlogApi.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
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

		public AccountController(UserManager<Account> userManager, IMapper mapper, TokenService tokenService)
		{
			_userManager = userManager;
			_mapper = mapper;
			_tokenService = tokenService;
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

			}
			catch (Exception ex)
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
			}
			catch
			{
				return BadRequest();
			}

		}

		[Authorize( Roles = "Admin")]
		[HttpGet("GetAllUser")]
		public async Task<ActionResult> GetAllUser()
		{
			var user = await _userManager.Users.ToListAsync();
			return Ok(user);
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Member,Admin")]
		[HttpGet("CurrentUser")]
		public async Task<ActionResult> CurrentUser()
		{
			try
			{
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

		[Authorize(Roles = "Member,Admin")]
		[HttpPut("UpdateUser")]
		public async Task<ActionResult<Account>> UpdateUser(UpdateAccountDto updateAccountDto)
		{
			var userId = User.FindFirstValue(ClaimTypes.Email);

			var getUser = await _userManager.FindByIdAsync(userId);
			getUser.MemberName = updateAccountDto.MemberName;
			getUser.InforUser = updateAccountDto.InforUser;
			getUser.Avatar = updateAccountDto.Avatar;


			var result =  await _userManager.UpdateAsync(getUser);
			if (result.Succeeded) return Ok("Thông tin tài khoản đã được cập nhật.");
			return BadRequest("Lỗi khi cập nhật thông tin tài khoản.");
		}

		[Authorize(Roles = "Admin")]
		[HttpDelete("DeleteAccount")]
		public async Task<ActionResult> DeleteAccount(int userId)
		{
			try
			{
				var getUser = await _userManager.Users.FirstOrDefaultAsync(find => find.Id == userId);
				if (getUser != null) _userManager.DeleteAsync(getUser);
				
				return Ok("Đã xóa tk : " + getUser);
			} catch
			{
				return BadRequest("Không xóa được!");
			}
		}
    }
}
