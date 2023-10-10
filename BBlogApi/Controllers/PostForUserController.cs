using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Extensions;
using BBlogApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BBlogApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PostForUserController : ControllerBase
	{
		private readonly BlogContext _db;
		private readonly UserManager<Account> _userManager;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public PostForUserController(BlogContext db, UserManager<Account> userManager, IHttpContextAccessor httpContextAccessor)
        {
			_db = db;
			_userManager = userManager;
			_httpContextAccessor = httpContextAccessor;
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Member")]
		[HttpPost("AddPostWithUser")]
		public async Task<ActionResult<Post>> AddPostForAccount(PostDto postDto)
		{
			string? userId = _userManager.GetUserId(User);
			if (userId == null) return Unauthorized();

			var newPost = new Post
			{
				Title = postDto.Title,
				BriefContent = postDto.BriefContent,
				Content = postDto.Content,
				PicturePostUrl = postDto.PicturePostUrl,
				OrderNo = postDto.OrderNo,
				TagSearch = postDto.TagSearch,
				PostStatus = postDto.PostStatus,
				CreateDate = DateTime.UtcNow,
				CategoryId = postDto.CategoryId,
				UserId = userId
			};

			await _db.PostZ.AddAsync(newPost);
			await _db.SaveChangesAsync();

			return Ok(newPost);
		}
	}
}
