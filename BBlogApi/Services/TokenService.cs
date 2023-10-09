using BBlogApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BBlogApi.Services
{
	public class TokenService
	{
		private readonly UserManager<Account> _userManager;
		private readonly IConfiguration _config;

		public TokenService(UserManager<Account> userManager, IConfiguration config)
        {
			_userManager = userManager;
			_config = config;
		}

		public async Task<string> GenerateToken(Account account)
		{
			var claims = new List<Claim>
			{
				  new Claim(ClaimTypes.Email, account.Email),
				  new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
			};

			var roles = await _userManager.GetRolesAsync(account);
			foreach (var role in roles)
			{
				claims.Add(new Claim(ClaimTypes.Role, role));
			}

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SecretKey"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

			var token = new JwtSecurityToken(
				issuer: null,
				audience: null,
				claims: claims,
				expires: DateTime.UtcNow.AddDays(7),
				signingCredentials: creds
				);

			
			return new JwtSecurityTokenHandler().WriteToken(token); // viết token này ra
		}
    }
}
