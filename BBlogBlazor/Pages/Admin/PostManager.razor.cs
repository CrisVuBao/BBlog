using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Admin
{
    public partial class PostManager : ComponentBase
    {
        [Inject] public IPostClient PostClient { get; set; }
        private List<PostDto> PostAll { get; set; }

        protected async override Task OnInitializedAsync()
        {
            PostAll = await PostClient.GetPostAll();
        }
    }
}
