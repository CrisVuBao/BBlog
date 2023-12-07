using BBlog.Models;
using BBlogBlazor.Services.IServices;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Authentication
{
    public partial class Login
    {
        [Inject] private IAccountClient AccountClient { get; set; }

        public bool ShowErrors;
        public string Error = "";
        public LoginDto LoginModel = new LoginDto();

        private async Task HandleLogin()
        {
            ShowErrors = false;

            var result = await AccountClient.Login(LoginModel);
            if(result.Successful)
            {
                navigationManager.NavigateTo("/admin-home");
            }else
            {
                ShowErrors = true;
                Error = result.Error;
            }
        }
    }
}
