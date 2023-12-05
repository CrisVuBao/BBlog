using AutoMapper;
using BBlogApi.Data;
using BBlogApi.DTOs;
using BBlogApi.Helpers;
using BBlogApi.Models;
using BBlogApi.Services.IServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Security.Claims;

namespace BBlogApi.Services
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogContext _db;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;
        private readonly ImageService _imageService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PostRepository(BlogContext db, IMapper mapper, UserManager<Account> userManager, ImageService imageService, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _mapper = mapper;
            _userManager = userManager;
            _imageService = imageService;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
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
        public async Task<List<PostDto>> GetPostWithCate(int id)
        {
            //var getPost = await _db.PostZ.GroupJoin(_db.CategorieZ, post => post.CategoryId, cate => cate.CategoryId, (p, c) => new
            //{
            //	Cate = c,
            //	Post = p
            //})
            //	.Where(w => w.CategoryId == id).ToListAsync();

            var getPost = await _db.PostZ.Join(_db.CategorieZ, p => p.CategoryId, c => c.CategoryId, (post, cate) => new { post, cate })
                .Where(w => w.post.CategoryId == id)
                .Select(s => new PostDto
                {
                    PostId = s.post.PostId,
                    Title = s.post.Title,
                    BriefContent = s.post.BriefContent,
                    Content = s.post.Content,
                    PicturePostUrl = s.post.PicturePostUrl,
                    TagSearch = s.post.TagSearch,
                    PostStatus = s.post.PostStatus,
                    CreateDate = s.post.CreateDate,
                    CategoryId = s.post.CategoryId,
                    Categories = s.cate
                }).ToListAsync();
            return getPost;
        }

        // Lấy bài viết theo chủ đề công nghê
        public async Task<List<Post>> GetPostWithCateIT()
        {
            var getPost = await _db.PostZ.Where(w => w.CategoryId == 1 || w.CategoryId == 2 || w.CategoryId == 3).ToListAsync();
            return getPost;
        }

        public async Task<List<Post>> GetPostWithCatePersonal()
        {
            var getPost = await _db.PostZ.Where(w => w.CategoryId == 4 || w.CategoryId == 5).ToListAsync();
            return getPost;
        }

        // Add Post
        public async Task<Post> AddPost(CreatePostDto createPostDto)
        {
            var addPost = _mapper.Map<Post>(createPostDto); // tạo ra đối tượng mới kiểu Post, và sao chép dữ liệu từ postDto vào trong đối tượng Post

            addPost.PicturePostUrl = CreateFile(createPostDto.PictureUrlData, createPostDto.PictureUrlOriginal);

            await _db.PostZ.AddAsync(addPost);
            await _db.SaveChangesAsync();

            return addPost;
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

        private string CreateFile(string imageBase64, string imageName)
        {
            var url = _httpContextAccessor.HttpContext.Request.Host.Value;
            var ext = Path.GetExtension(imageName);
            var fileName = $"{Guid.NewGuid()}.{ext}";

            var path = $"{_webHostEnvironment.WebRootPath}\\images\\products\\{fileName}";

            byte[] image = Convert.FromBase64String(imageBase64);

            var fileStream = System.IO.File.Create(path);
            fileStream.Write(image, 0, image.Length);
            fileStream.Close();

            return $"https://{url}/images/products/{fileName}";
        }
    }
}
