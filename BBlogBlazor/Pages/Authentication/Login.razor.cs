using BBlog.Models;
using BBlogBlazor.Services.IServices;
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
                ReturnUrl = queryParam["returnUrl"];
                if (string.IsNullOrEmpty(ReturnUrl))
                {
                    navigationManager.NavigateTo("/", forceLoad: true);
                }else
                {
                    navigationManager.NavigateTo("/" + ReturnUrl);
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
