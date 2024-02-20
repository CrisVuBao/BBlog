using BBlog.Models;
using BBlogBlazor.Services;
using BBlogBlazor.Services.IServices;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Authentication
{
    public partial class Profile
    {
        [Inject] private IPostForUserClient PostForUserClient { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        private List<PostDto> PostForUser { get; set; }

        //private AccountDto userProfile;

        //[Inject] private IAccountClient AccountClient { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PostForUser = await PostForUserClient.GetAllPostForUser();
        }

        public async Task HandleDeletePost(string id)
        {
            var deletePost = await PostForUserClient.DeletePostForUser(id);

            if (deletePost != null)
            {
                await Swal.FireAsync("Xóa Thành Công", "Chờ Xíu Nhé", "success");
                NavigationManager.NavigateTo("profile", forceLoad: true);
            }
            else
            {
                await Swal.FireAsync("Không Xóa được", "Có lỗi xảy ra trong hệ thống!", "error");
            }

            StateHasChanged();
        }
    }
}
