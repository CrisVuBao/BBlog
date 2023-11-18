using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Blog
{
    public partial class BlogDetail
    {
        [Inject] public IPostClient PostClient { get; set; }

        [Parameter]
        public int Id { get; set; }

        private PostDto PostIds;

        protected override async Task OnParametersSetAsync()
        {
            PostIds = await PostClient.GetPostId(Id);
        }
    }
}
