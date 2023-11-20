using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using System.Net.Http.Json;

namespace BBlogBlazor.Services
{
    public class CategoryClient : ICategoryClient
    {
        public HttpClient _httpClient;

        public CategoryClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CategoryDto> GetCateId(string id)
        {
            try
            {
                var getCateId = await _httpClient.GetFromJsonAsync<CategoryDto>($"api/Categories/{id}");
                return getCateId;
            } catch
            {
                throw;
            }

        }
    }
}
