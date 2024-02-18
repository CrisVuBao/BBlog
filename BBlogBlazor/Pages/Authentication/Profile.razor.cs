using BBlog.Models;
using BBlogBlazor.Services.IServices;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Authentication
{
    public partial class Profile
    {
        [Inject] private IPostForUserClient PostForUserClient { get; set; }

        private List<PostDto> PostForUser { get; set; }

        //private AccountDto userProfile;

        //[Inject] private IAccountClient AccountClient { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PostForUser = await PostForUserClient.GetAllPostForUser();
        }
    }
}
