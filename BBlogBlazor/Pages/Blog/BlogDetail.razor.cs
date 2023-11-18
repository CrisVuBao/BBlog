using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Blog
{
    public partial class BlogDetail
    {
        [Inject] public IPostClient PostClient { get; set; }

        [Parameter]
        public string PostId { get; set; }

        private PostDto PostDetail { get; set; }

        protected async override Task OnInitializedAsync()
        {
            PostDetail = await PostClient.GetPostDetail(PostId);
        }
    }
}
