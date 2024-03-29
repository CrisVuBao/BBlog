﻿using AutoMapper;
using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Models;
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
	public class PostForUserController : ControllerBase
	{
		private readonly BlogContext _db;
		private readonly UserManager<Account> _userManager;
		private readonly IMapper _mapper;

		public PostForUserController(BlogContext db, UserManager<Account> userManager, IMapper mapper)
        {
			_db = db;
			_userManager = userManager;
			_mapper = mapper;
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Member")]
		[HttpPost("AddPostWithUser")]
		public async Task<ActionResult<Post>> AddPostForAccount(PostDto postDto)
		{
			string? userId = User.FindFirstValue(ClaimTypes.Email);
			if (userId == null) return Unauthorized();

			var newPost = new Post
			{
				Title = postDto.Title,
				BriefContent = postDto.BriefContent,
				Content = postDto.Content,
				PicturePostUrl = postDto.PicturePostUrl,
				TagSearch = postDto.TagSearch,
				CreateDate = DateTime.UtcNow,
				CategoryId = postDto.CategoryId,
				UserId = userId
			};

			await _db.PostZ.AddAsync(newPost);
			await _db.SaveChangesAsync();

			return Ok(newPost);
		}

		[HttpGet("GetPostForUser")]
		public async Task<ActionResult> GetPostForUser()
		{
			string? userId = User.FindFirstValue(ClaimTypes.Email);
			if (userId == null) return Unauthorized();

			var getPost =  await _db.PostZ.Where(w => w.UserId == userId).OrderByDescending(o => o.PostId).ToListAsync();

			return Ok(getPost);
		}

		[HttpPut("UpdatePostForUser/{postId}")]
		public async Task<ActionResult<Post>> UpdatePostForUser(int postId, UpdatePostDto UpdatePostDto)
		{
			string? userId = User.FindFirstValue(ClaimTypes.Email);
			if (userId == null) return Unauthorized();

			// lấy id bài viết muốn sửa
			var post = await _db.PostZ.FindAsync(postId);

			if (post == null) return NotFound();

			if (post.UserId != userId) return Forbid("Bạn không có quyền truy cập bài viết này"); // người dùng ko có quyền chỉnh sửa bài viết

				post.Title = UpdatePostDto.Title;
				post.BriefContent = UpdatePostDto.BriefContent;
				post.Content = UpdatePostDto.Content;
				post.PicturePostUrl = UpdatePostDto.PicturePostUrl;
				post.TagSearch = UpdatePostDto.TagSearch;
				post.CreateDate = DateTime.Now;
				post.CategoryId = UpdatePostDto.CategoryId;
				post.UserId = userId;
			await _db.SaveChangesAsync();

			return Ok(post);
		}

		[HttpDelete("DeletePostForUser/{postId}")]
		public async Task<ActionResult> DeletePostForUser(int postId)
		{
			var userId = User.FindFirstValue(ClaimTypes.Email);
			if (userId == null) return Unauthorized();

			var post = await _db.PostZ.FindAsync(postId);
			if (post == null) return NotFound();

			if (post.UserId != userId) return Forbid("Bạn không có quyền truy cập bài viết này");

			_db.Remove(post);
			await _db.SaveChangesAsync();

			return Ok("Đã xóa bài viết");
		}
	}
}
