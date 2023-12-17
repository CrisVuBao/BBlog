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
    }
}
