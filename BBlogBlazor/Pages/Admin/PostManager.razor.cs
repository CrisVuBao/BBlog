using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Admin
{
    public partial class PostManager : ComponentBase
    {
        [Inject] public IPostClient PostClient { get; set; }
        private List<PostDto> PostAll { get; set; }
        [Inject] private ICategoryClient CategoryClient { get; set; }
        List<CategoryDto> categories = new List<CategoryDto>();
        List<PostDto> PostWithCate = new List<PostDto>();
        CategoryDto cateId = new CategoryDto();
        private string selectedTopicId;

        protected async override Task OnInitializedAsync()
        {
            PostAll = await PostClient.GetPostAll();
            categories = await CategoryClient.GetAllCate();
            PostWithCate = await PostClient.GetPostWithCateId("1");
        }

        private async Task SelectPost(ChangeEventArgs e)
        {
            var topicId = Convert.ToString(e.Value);
            PostWithCate = await PostClient.GetPostWithCateId(topicId);
            StateHasChanged();
        }

        private void UpdatePage()
        {
            NavigationManager.NavigateTo("/update-post-admin");
        }

        public async Task HandleDeletePost(string id)
        {
            var deletePost = await PostClient.DeletePost(id);

            if (deletePost != null)
            {
                await Swal.FireAsync("Xóa Thành Công", "Chờ Xíu Nhé", "success");
                NavigationManager.NavigateTo("post-admin-manager", forceLoad: true);
            }
            else
            {
                await Swal.FireAsync("Không Xóa được", "Có lỗi xảy ra trong hệ thống!", "error");
            }

            StateHasChanged();
        }
    }
}
