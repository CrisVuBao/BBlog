using BBlog.Models;
using BBlogBlazor.Services.IServices;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Admin
{
    public partial class UserManager
    {
        [Inject] private IAccountClient AccountClient { get; set; }

        public List<AccountDto> GetAccount { get; set; }

        protected async override Task OnInitializedAsync()
        {
            GetAccount = await AccountClient.GetAllUser();
        }
    }
}
