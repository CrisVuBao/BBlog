using BBlog.Models;

namespace BBlogBlazor.Services.IServices
{
    public interface IPostForUserClient
    {
        Task<List<PostDto>> GetAllPostForUser();
    }
}
