using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using System.Net.Http.Json;

namespace BBlogBlazor.Services
{
    public class PostClient : IPostClient
    { 
        public HttpClient _httpClient;

        public PostClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PostDto>> GetPostAll()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PostDto>>("api/Post/GetAllPost");
                return result;
            } catch
            {
                throw;
            }

        }

        public async Task<PostDto> GetPostId(int id)
        {
            try
            {
                var postId = await _httpClient.GetFromJsonAsync<PostDto>("api/Post/{id}");
                return postId;
            }catch
            {
                throw;
            }
        }
    }
}
