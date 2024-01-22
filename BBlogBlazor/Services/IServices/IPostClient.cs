using BBlog.Models;

namespace BBlogBlazor.Services.IRepository
{
    public interface IPostClient
    {
        Task<List<PostDto>> GetPostAll();
        Task<PostDto> GetPostDetail(string id);
        Task<List<PostDto>> GetTopPost();
        Task<List<PostDto>> GetPostWithCateIT();
        Task<List<PostDto>> GetPostWithCatePersonal();
        Task<List<PostDto>> GetPostWithCateGame();
        Task<List<PostDto>> GetPostWithCateId(string id);
        Task<bool> AddPost(PostDto post);
        Task<bool> UpdatePost(string id, PostDto post);
        Task<bool> DeletePost(string id);
        Task<List<PostDto>> SearchPost(string searchText);
    }
}
