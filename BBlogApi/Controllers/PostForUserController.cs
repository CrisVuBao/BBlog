using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BBlogApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PostForUserController : ControllerBase
	{
		private readonly BlogContext _db;
		private readonly UserManager<Account> _userManager;

		public PostForUserController(BlogContext db, UserManager<Account> userManager)
        {
			_db = db;
			_userManager = userManager;
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[HttpPost("AddPostWithUser")]
		public async Task<ActionResult<Post>> AddPostForAccount(PostDto postDto)
		{
			var currentUser = await _userManager.GetUserAsync(User);
			if (currentUser == null) return Unauthorized();

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
				UserId = currentUser.Id
			};

			await _db.PostZ.AddAsync(newPost);
			await _db.SaveChangesAsync();

			return Ok(newPost);
		}
	}
}
