using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        public async Task<PostDto> GetPostDetail(string id)
        {
            try
            {
                var postDetail = await _httpClient.GetFromJsonAsync<PostDto>($"api/Post/{id}");
                return postDetail;
            }catch
            {
                throw;
            }
        }


        public async Task<List<PostDto>> GetTopPost()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PostDto>>("api/Post/GetTopPost");
                return result;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<PostDto>> GetPostWithCateIT()
        {
            var getPost = await _httpClient.GetFromJsonAsync<List<PostDto>>("api/Post/GetPostWithCateIT");
            return getPost;
        }

        public async Task<List<PostDto>> GetPostWithCatePersonal()
        {
            var getPost = await _httpClient.GetFromJsonAsync<List<PostDto>>("api/Post/GetPostWithCatePersonal");
            return getPost;
        }

        public async Task<List<PostDto>> GetPostWithCateId(string id)
        {
            var getPost = await _httpClient.GetFromJsonAsync<List<PostDto>>($"api/Post/GetPostWithCategories/{id}");
            return getPost;
        }

        public async Task<bool> AddPost(CreatePost post)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Post/AddPost", post);          
            return result.IsSuccessStatusCode;

            //var itemJson = new StringContent(JsonSerializer.Serialize(post), Encoding.UTF8, "application/json");

            //var response = await _httpClient.PostAsync("api/Post/AddPost", itemJson);
            //if (response.IsSuccessStatusCode)
            //{
            //    var responseBody = await response.Content.ReadAsStreamAsync();

            //    var addPost = await JsonSerializer.DeserializeAsync<PostDto>(responseBody, new JsonSerializerOptions
            //    {
            //        PropertyNameCaseInsensitive = true
            //    });

            //    return addPost;
            //}

            //return null;
        }
    }
}
