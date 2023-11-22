using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Blog
{
    public partial class BlogIT : ComponentBase
    {
        [Inject] public IPostClient PostClient { get; set; }
        [Inject] public ICategoryClient CategoryClient { get; set; }

        private List<PostDto> Posts;
        private List<PostDto> PostWithCateIT;
        private List<PostDto> GetTopPost { get; set; }
        private CategoryDto GetCateThuThuat { get; set; }
        private CategoryDto GetCatePhanMemIT { get; set; }
        private CategoryDto GetCateTinCongNghe { get; set; }



        protected override async Task OnInitializedAsync()
        {
            Posts = await PostClient.GetPostAll();
            PostWithCateIT = await PostClient.GetPostWithCateIT();
            GetTopPost = await PostClient.GetTopPost();
            GetCateThuThuat = await CategoryClient.GetCateId("1");
            GetCatePhanMemIT = await CategoryClient.GetCateId("2");
            GetCateTinCongNghe = await CategoryClient.GetCateId("3");
        }
    }
}
