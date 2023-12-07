using BBlog.Models;
using BBlogBlazor.Services.IServices;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace BBlogBlazor.Services
{
    public class AccountClient : IAccountClient
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AccountClient(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider ,ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<List<AccountDto>> GetAllUser()
        {
            var getUser = await _httpClient.GetFromJsonAsync<List<AccountDto>>("api/Account/GetAllUser");
            return getUser;
        }

        public async Task<LoginResponse> Login(LoginDto login)
        {
            //var loginJson = JsonSerializer.Serialize(login);
            var response = await _httpClient.PostAsJsonAsync("api/Account/Login", login);
            var loginResult = JsonSerializer.Deserialize<LoginResponse>(await response.Content.ReadAsStringAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (!response.IsSuccessStatusCode)
            {
                return loginResult!;
            }

            await _localStorage.SetItemAsync("authToken", loginResult!.Token);
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(login.Email!);
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", loginResult.Token);

            return loginResult;


            //var result = await _httpClient.PostAsJsonAsync("api/Account/Login", login);
            //var content = await result.Content.ReadAsStringAsync();
            //var loginResponse = JsonSerializer.Deserialize<LoginResponse>(content,
            //    new JsonSerializerOptions()
            //    {
            //        PropertyNameCaseInsensitive = true
            //    });
            //if(!result.IsSuccessStatusCode)
            //{
            //    return loginResponse;
            //}
            //await _localStorage.SetItemAsync("authToken", loginResponse.Token);
            //((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(login.Email);
            //_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", loginResponse.Token);
            //return loginResponse;

        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public Task<RegisterDto> Register(RegisterDto register)
        {
            throw new NotImplementedException();
        }
    }
}
