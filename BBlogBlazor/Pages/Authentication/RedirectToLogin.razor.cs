using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BBlogBlazor.Pages.Authentication
{
    public partial class RedirectToLogin
    {
        [CascadingParameter]
        public Task<AuthenticationState> _authenState { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        bool notAuthoried { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            var authenState = await _authenState;
            if(authenState?.User?.Identity is null || !authenState.User.Identity.IsAuthenticated)
            {
                var returnUrl = navigationManager.ToBaseRelativePath(navigationManager.Uri);
                if (string.IsNullOrEmpty(returnUrl))
                {
                    navigationManager.NavigateTo("login");
                } else
                {
                    navigationManager.NavigateTo($"login?returnUrl={returnUrl}");
                }
            }else
            {
                notAuthoried = true;
            }
        }
    }
}
