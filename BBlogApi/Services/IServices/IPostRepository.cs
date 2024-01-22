using BBlogApi.DTOs;
using BBlogApi.Models;

namespace BBlogApi.Services.IServices
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAll();
        Task<Post> GetPostById(int id);
        Task<List<Post>> GetTopPost();
        Task<List<PostDto>> GetPostWithCate(int id);
        Task<List<Post>> GetPostWithCateIT();
        Task<List<Post>> GetPostWithCatePersonal();
        Task<List<Post>> GetPostWithCateGame();
        Task<Post> AddPost(CreatePostDto createPostDto);
        Task<Post> UpdatePost(int id, UpdatePostDto postDto);
        Task<Post> DeletePost(int id);
        Task<List<Post>> SearchPost(string searchText);
    }
}
