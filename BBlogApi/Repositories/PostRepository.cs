using AutoMapper;
using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Helpers;
using BBlogApi.Models;
using BBlogApi.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Security.Claims;

namespace BBlogApi.Repository
{
	public class PostRepository : IPostRepository
	{
		private readonly BlogContext _db;
		private readonly IMapper _mapper;
		private readonly UserManager<Account> _userManager;

		public PostRepository(BlogContext db, IMapper mapper, UserManager<Account> userManager)
        {
			_db = db;
			_mapper = mapper;
			_userManager = userManager;
		}

		// Get All
		public async Task<List<Post>> GetAll()
		{
			var post = await _db.PostZ.OrderBy(o => o.PostId).ToListAsync();
			return post;
		}

		// Get Post by Id
		public async Task<Post> GetPostById(int id)
		{
			var getPostId = await _db.PostZ.FindAsync(id);

			// ++ số lượt xem
			getPostId.ViewCount++;
			await _db.SaveChangesAsync();
			return getPostId;
		}

		// Get Post with Category Id
		public async Task<List<Post>> GetPostWithCate(int id)
		{
			var getPost = await _db.PostZ.Where(w => w.CategoryId == id).ToListAsync();
			return getPost;
		}

		// Lấy bài viết theo chủ đề công ngh
        public async Task<List<Post>> GetPostWithCateIT()
        {
			var getPost = await _db.PostZ.Where(w => w.CategoryId == 1 || w.CategoryId == 2 || w.CategoryId == 3).ToListAsync();
			return getPost;
        }

        // Add Post
        public async Task<Post> AddPost(PostDto postDto)
		{
			var addPost = _mapper.Map<Post>(postDto); // tạo ra đối tượng mới kiểu Post, và sao chép dữ liệu từ postDto vào trong đối tượng Post

			await _db.PostZ.AddAsync(addPost);
			await _db.SaveChangesAsync();

			return addPost;
		}

		// Thêm bài post cho mỗi tài khoản
		public async Task<Post> AddPostForAccount(PostDto postDto)
		{
			throw new NotImplementedException();
		}

		public async Task<Post> UpdatePost(Post post)
		{
			var updatePost = _mapper.Map<Post>(post);

			 _db.PostZ.Update(updatePost);
			await _db.SaveChangesAsync();

			return updatePost;
		}

		public async Task<Post> DeletePost(int id)
		{
			var deletePost = await _db.PostZ.FindAsync(id);
			_db.PostZ.Remove(deletePost);
			await _db.SaveChangesAsync();

			return deletePost;
		}

		public async Task<List<Post>> GetTopPost()
		{
			var topPost = await _db.PostZ.OrderByDescending(p => p.ViewCount).Take(5).ToListAsync();
			return topPost;
		}


    }
}
