using BBlog.Models;
using BBlogBlazor.IHelper;
using BBlogBlazor.Services.IServices;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BBlogBlazor.Pages.Authentication
{
    public partial class Register
    {
        [Inject] private IAccountClient AccountClient { get; set; }


        public bool ShowErrors;
        public string Error = "";
        private RegisterDto RegisterModel = new RegisterDto();

        private async Task HandleRegister()
        {
            ShowErrors = false;

            var result = await AccountClient.Register(RegisterModel);
            if (result.RegisterSuccessful)
            {
                await Swal.FireAsync("Đăng ký thành công", "Chuyển qua trang đăng nhập trong giây lát", "success");
                navigationManager.NavigateTo("/login");
            }
            else
            {
                await Swal.FireAsync("Đăng ký không thành công", "Vui lòng kiểm tra lại", "error");
                ShowErrors = true;
                Error = result.Error;
            }
        }

        private async Task Test()
        {
            await JsRuntime.InvokeVoidAsync("ShowSwal", "success", "Đăng ký thành công :)");
        }
    }
}
