using BBlog.Models;
using BBlogBlazor.Pages.Authentication;
using BBlogBlazor.Services.IServices;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
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

        public async Task<AccountDto> GetCurrentUser()
        {
            var getUser = await _httpClient.GetFromJsonAsync<AccountDto>("api/Account/CurrentUser");
            return getUser;
        }

        public async Task<LoginResponse> Login(LoginDto login)
        {
            var loginJson = JsonConvert.SerializeObject(login);
            var response = await _httpClient.PostAsync("api/Account/Login", 
                new StringContent(loginJson, Encoding.UTF8, "application/json"));

            var loginResult = JsonConvert.DeserializeObject<LoginResponse>(await response.Content.ReadAsStringAsync());

            if (!response.IsSuccessStatusCode)
            {
                return loginResult!;
            }

            await _localStorage.SetItemAsync("authToken", loginResult!.Token);
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(login.Email!);
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", loginResult.Token);

            return loginResult;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegisterResponse> Register(RegisterDto register)
        {
            var registerJson = JsonConvert.SerializeObject(register);
            var bodyContent = new StringContent(registerJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Account/Register", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();

            var loginResult = JsonConvert.DeserializeObject<RegisterDto>(contentTemp);

            if (response.IsSuccessStatusCode)
            {
                return new RegisterResponse { RegisterSuccessful = true };
            }else
            {
                return new RegisterResponse { RegisterSuccessful = false };
            }
        }
    }
}
