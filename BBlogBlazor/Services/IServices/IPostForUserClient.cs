using BBlog.Models;

namespace BBlogBlazor.Services.IServices
{
    public interface IPostForUserClient
    {
        Task<List<PostDto>> GetAllPostForUser();
        Task<bool> UpdatePostForUser(string id, PostDto post);
        Task<bool> DeletePostForUser(string id);
    }
}
