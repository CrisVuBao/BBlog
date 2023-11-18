using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Blog
{
    public partial class Blog : ComponentBase
    {
        [Inject] public IPostClient PostClient { get; set; }

        public int Id { get; set; }
        private List<PostDto> Posts;

        protected override async Task OnInitializedAsync()
        {
            Posts = await PostClient.GetPostAll();
        }


    }
}
