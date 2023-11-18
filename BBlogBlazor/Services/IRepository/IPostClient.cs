using BBlog.Models;

namespace BBlogBlazor.Services.IRepository
{
    public interface IPostClient
    {
        Task<List<PostDto>> GetPostAll();
        Task<PostDto> GetPostId(int id);
    }
}
