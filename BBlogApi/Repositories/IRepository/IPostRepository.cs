using BBlogApi.DTOs;
using BBlogApi.Models;

namespace BBlogApi.Repository.IRepository
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAll();
        Task<Post> GetPostById(int id);
        Task<List<Post>> GetPostWithCate(int id);
        Task<Post> AddPost(PostDto postDto);
        Task<Post> AddPostForAccount(PostDto postDto);
        Task<Post> UpdatePost(Post post);
        Task<Post> DeletePost(int id);
    }
}
