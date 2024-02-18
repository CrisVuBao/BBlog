using BBlog.Models;
using BBlogBlazor.Services.IServices;
using System.Net.Http.Json;

namespace BBlogBlazor.Services
{
    public class PostForUserClient : IPostForUserClient
    {
        private readonly HttpClient _httpClient;

        public PostForUserClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PostDto>> GetAllPostForUser()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PostDto>>("api/PostForUser/GetPostForUser");
                return result;
            } catch
            {
                throw;
            }
        }
    }
}
