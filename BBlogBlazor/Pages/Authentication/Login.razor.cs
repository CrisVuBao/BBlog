using BBlog.Models;
using BBlogBlazor.Services.IServices;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Web;

namespace BBlogBlazor.Pages.Authentication
{
    public partial class Login
    {
        [Inject] private IAccountClient AccountClient { get; set; }

        public bool ShowErrors;
        public string Error = "";
        public LoginDto LoginModel = new LoginDto();
        public string ReturnUrl { get; set; }

        private async Task HandleLogin()
        {
            ShowErrors = false;

            var result = await AccountClient.Login(LoginModel);
            if (result.Successful)
            {
                await Swal.FireAsync("Đăng nhập thành công", "Chuyển hướng trong giây lát", "success");
                var absoluteUri = new Uri(navigationManager.Uri);
                var queryParam = HttpUtility.ParseQueryString(absoluteUri.Query);

                var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;

                ReturnUrl = queryParam["returnUrl"];

                if (user.Identity.IsAuthenticated)
                {
                    if (user.IsInRole("Admin")) navigationManager.NavigateTo("/admin-home", forceLoad: true);
                    else if (user.IsInRole("Member")) navigationManager.NavigateTo("/" + ReturnUrl);
                }

            }
            else
            {
                await Swal.FireAsync("Đăng nhập thất bại!", "Hãy kiểm tra tên tài khoản hoặc mật khẩu!", "error");
                ShowErrors = true;
                Error = result.Error;
            }
        }
    }
}
