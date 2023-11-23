using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Blog.BlogChild
{
    public partial class BlogChild
    {
        [Inject] IPostClient PostClient { get; set; }
        [Inject] public ICategoryClient CategoryClient { get; set; }


        [Parameter]
        public string CateId { get; set; }
        public List<PostDto> GetPostWithCateId { get; set; }
        private CategoryDto GetCateThuThuat { get; set; }
        private CategoryDto GetCatePhanMemIT { get; set; }
        private CategoryDto GetCateTinCongNghe { get; set; }
        private string firstPostWithCategory;

        protected async override Task OnInitializedAsync()
        {
            GetPostWithCateId = await PostClient.GetPostWithCateId(CateId);
            GetCateThuThuat = await CategoryClient.GetCateId("1");
            GetCatePhanMemIT = await CategoryClient.GetCateId("2");
            GetCateTinCongNghe = await CategoryClient.GetCateId("3");

            // Sử dụng LINQ để tìm phần tử đầu tiên có CategoryName không rỗng hoặc null
            firstPostWithCategory = GetPostWithCateId.FirstOrDefault()?.CategoryName;
        }
    }
}
