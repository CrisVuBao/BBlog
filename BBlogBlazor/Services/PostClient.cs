using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Http;
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

        public async Task<List<PostDto>> GetPostWithCateGame()
        {
            var getPost = await _httpClient.GetFromJsonAsync<List<PostDto>>("api/Post/GetPostWithCateGame");
            return getPost;
        }

        public async Task<List<PostDto>> GetPostWithCateId(string id)
        {
            var getPost = await _httpClient.GetFromJsonAsync<List<PostDto>>($"api/Post/GetPostWithCategories/{id}");
            return getPost;
        }

        public async Task<bool> AddPost(PostDto post)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Post/AddPost", post);          
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePost(string id, PostDto post)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/Post/UpdatePost/{id}", post);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePost(string id)
        {
            var deletePost = await _httpClient.DeleteAsync($"api/Post/DeletePost/{id}");
            return deletePost.IsSuccessStatusCode;
        }

        public async Task<List<PostDto>> SearchPost(string searchText)
        {
            return await _httpClient.GetFromJsonAsync<List<PostDto>>($"api/Post/Search/{searchText}"); 
        }
    }
}
