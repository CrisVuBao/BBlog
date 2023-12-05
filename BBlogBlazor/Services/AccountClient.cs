using BBlog.Models;
using BBlogBlazor.Services.IServices;
using System.Net.Http.Json;

namespace BBlogBlazor.Services
{
    public class AccountClient : IAccountClient
    {
        private readonly HttpClient _httpClient;

        public AccountClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AccountDto>> GetAllUser()
        {
            var getUser = await _httpClient.GetFromJsonAsync<List<AccountDto>>("api/Account/GetAllUser");
            return getUser;
        }
    }
}
