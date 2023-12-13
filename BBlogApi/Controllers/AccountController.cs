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
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BBlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly SignInManager<Account> _signInManager;
        private readonly IMapper _mapper;
        private readonly TokenService _tokenService;
        private readonly APISettings _apiSetting;

        public AccountController(UserManager<Account> userManager, SignInManager<Account> signInManager, IMapper mapper, TokenService tokenService, IOptions<APISettings> options)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _tokenService = tokenService;
            _apiSetting = options.Value;
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register([FromBody] RegisterDto registerDto)
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

                if (registerDto.Password != registerDto.CofirmPassword)
                {
                    return BadRequest(new Response { Status = "Error!", Message = "Mật khẩu không trùng nhau!" });
                }

                var result = await _userManager.CreateAsync(user, registerDto.Password);
                if (!result.Succeeded)
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

                if (result.Succeeded) await _userManager.AddToRoleAsync(user, "Admin");

                return Ok(user);

            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("Login")]
        public async Task<ActionResult<AccountDto>> Login([FromBody] LoginDto loginDto)
        {
            try
            {
                if (loginDto == null || !ModelState.IsValid) return BadRequest();

                var result = await _userManager.FindByNameAsync(loginDto.Email);
                //var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, false, false);
                if (result != null)
                {
                    var user = await _userManager.FindByEmailAsync(loginDto.Email);
                    if (user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password))
                    {
                        return Unauthorized(new Response
                        {
                            Status = "Error!",
                            Message = "Đăng nhập thất bại"
                        });
                    }

                    // Phần quan trọng để đăng nhập
                    var signinCreadentials = GetSigningCredentials();
                    var claims = await GetClaims(user);

                    var tokenOptions = new JwtSecurityToken(
                            issuer: _apiSetting.ValidIssuer,
                            audience: _apiSetting.ValidAudience,
                            claims: claims,
                            expires: DateTime.Now.AddDays(30),
                            signingCredentials: signinCreadentials
                        );

                    var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                    return Ok(new LoginResponse()
                    {
                        Successful = true,
                        Token = token,
                        UserDto = new AccountDto
                        {
                            Id = user.Id,
                            UserName = user.Email,
                            Email = user.Email,
                            MemberName = user.MemberName,
                            Avatar = user.Avatar,
                            InforUser = user.InforUser
                             
                        }
                    }); ;

                }else
                {
                    return Unauthorized(new LoginResponse
                    {
                        Successful = false,
                        Error = "Tài khoản chưa đưa xác thực!"
                    });

                }
                    return StatusCode(201);

            }
            catch
            {
                return BadRequest();
            }

        }

        //[Authorize( Roles = "Admin")]
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
            }
            catch
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


            var result = await _userManager.UpdateAsync(getUser);
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
            }
            catch
            {
                return BadRequest("Không xóa được!");
            }
        }

        // Phương thức bổ trợ
        private SigningCredentials GetSigningCredentials()
        {
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_apiSetting.SecretKey));

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims(Account user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim("Id", user.Id.ToString())
            };

            var roles = await _userManager.GetRolesAsync(await _userManager.FindByEmailAsync(user.Email));

            foreach(var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;

        }
    }
}
