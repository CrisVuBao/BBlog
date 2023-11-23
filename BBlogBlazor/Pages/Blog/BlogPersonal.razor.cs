using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Blog
{
    public partial class BlogPersonal
    {
        [Inject] public IPostClient PostClient { get; set; }
        [Inject] public ICategoryClient CategoryClient { get; set; }

        private List<PostDto> Posts;
        private List<PostDto> PostWithCatePersonal;
        private List<PostDto> GetTopPost { get; set; }
        private CategoryDto GetCateThuThuat { get; set; }
        private CategoryDto GetCatePhanMemIT { get; set; }
        private CategoryDto GetCateTinCongNghe { get; set; }



        protected override async Task OnInitializedAsync()
        {
            Posts = await PostClient.GetPostAll();
            PostWithCatePersonal = await PostClient.GetPostWithCatePersonal();
            GetTopPost = await PostClient.GetTopPost();
            GetCateThuThuat = await CategoryClient.GetCateId("4");
            GetCatePhanMemIT = await CategoryClient.GetCateId("5");
        }
    }
}
