using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc;
using BBlogApi.Services;
using BBlogApi.Services.IServices;

namespace BBlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly BlogContext _db;
        private readonly IPostRepository _postRepo;
        private readonly UserManager<Account> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PostController(BlogContext blogContext, IPostRepository postRepo, UserManager<Account> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _db = blogContext;
            _postRepo = postRepo;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        // Get all post
        [HttpGet("GetAllPost")]
        public async Task<ActionResult> GetAllPost()
        {
            try
            {
                if (_postRepo != null) return Ok(await _postRepo.GetAll());
                return NotFound();
            }
            catch
            {
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

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("GetTopPost")]
        public async Task<ActionResult> GetTopPost()
        {
            var topPost = await _postRepo.GetTopPost();
            return Ok(topPost);
        }

        // Get bài viết theo chủ đề
        [HttpGet("GetPostWithCategories/{id}")]
        public async Task<ActionResult> GetPostWithCategories(int id)
        {
            try
            {
                var getPostWithCateId = await _postRepo.GetPostWithCate(id);

                if (getPostWithCateId != null) return Ok(getPostWithCateId);
                return NotFound();

            }
            catch { return BadRequest(); }
        }

        [HttpGet("GetPostWithCateIT")]
        public async Task<ActionResult> GetPostWithCateIT()
        {
            try
            {
                var getPost = await _postRepo.GetPostWithCateIT();
                return Ok(getPost);

            }
            catch
            {
                return BadRequest("Không thể hiển thị bài viết");
            }
        }

        [HttpGet("GetPostWithCatePersonal")]
        public async Task<ActionResult> GetPostWithCatePersonal()
        {
            var getPost = await _postRepo.GetPostWithCatePersonal();
            return Ok(getPost);
        }

        [HttpGet("GetPostWithCateGame")]
        public async Task<ActionResult> GetPostWithCateGame()
        {
            var getPost = await _postRepo.GetPostWithCateGame();
            return Ok(getPost);
        }

        // Add
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPost("AddPost")]
        public async Task<ActionResult<Post>> AddPost(CreatePostDto createPostDto)
        {
            try
            {
                var addPost = await _postRepo.AddPost(createPostDto);
                return Ok(addPost);
            }
            catch
            {
                return BadRequest();
            }

        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
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

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        // Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePost(int id)
        {
            try
            {
                var deletePost = await _postRepo.DeletePost(id);
                return Ok("Đã xóa");

            }
            catch { return BadRequest(); }
        }
    }
}
