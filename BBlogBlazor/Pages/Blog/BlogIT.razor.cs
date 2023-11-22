using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Blog
{
    public partial class BlogIT : ComponentBase
    {
        [Inject] public IPostClient PostClient { get; set; }

        private List<PostDto> Posts;
        private List<PostDto> PostWithCateIT;

        protected override async Task OnInitializedAsync()
        {
            Posts = await PostClient.GetPostAll();
            PostWithCateIT = await PostClient.GetPostWithCateIT();
        }

    }
}
