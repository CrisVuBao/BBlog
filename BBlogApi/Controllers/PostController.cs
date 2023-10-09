using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Models;
using BBlogApi.Repository.IRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BBlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly BlogContext _db;
		private readonly IPostRepository _postRepo;
		private readonly UserManager<Account> _userManager;

		public PostController(BlogContext blogContext, IPostRepository postRepo, UserManager<Account> userManager)
        {
            _db = blogContext;
			_postRepo = postRepo;
			_userManager = userManager;
		}

		// Get
		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
		[HttpGet("GetAllPost")]
        public async Task<ActionResult> GetAllPost()
        {
            try {
                if (_postRepo != null)  return Ok(await _postRepo.GetAll());
                return NotFound();
			} catch {
                return BadRequest();
            }
        }

        // Get bài viết theo id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetPostId(int id)
        {
            try
            {
				var getPostId = await _postRepo.GetPostById(id);

				if (getPostId != null) return Ok(getPostId);
				return NotFound();

			} catch
            {
                return BadRequest();
            }

        }

        // Get bài viết theo chủ đề
        [HttpGet("GetPostWithCategories")]
        public async Task<ActionResult> GetPostWithCategories(int id)
        {
            try
            {
                var getPostWithCateId = await _postRepo.GetPostWithCate(id);

                if (getPostWithCateId != null) return Ok(getPostWithCateId);
                return NotFound();

            } catch { return BadRequest(); }
        }

        // Add
        [Authorize]
        [HttpPost("AddPost")]
        public async Task<ActionResult<Post>> AddPost(PostDto postDto)
        {
            try
            {
                var addPost = await _postRepo.AddPost(postDto);
				return Ok(addPost);
			} catch
            {
                return BadRequest();
            }
           
        }

        [HttpPut]
        public async Task<ActionResult<Post>> UpdatePost(Post post)
        {
            try
            {
				var updatePost = await _postRepo.UpdatePost(post);
				return Ok(updatePost);

			}
			catch { return BadRequest(); }

        }

        // Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePost(int id)
        {
            try
            {
                var deletePost = await _postRepo.DeletePost(id);
                return Ok("Đã xóa");

            } catch { return BadRequest(); }
        }
    }
}
