using BBlog.Models;
using BBlogBlazor.Services;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages.Blog
{
    public partial class BlogGame
    {
        [Inject] public IPostClient PostClient { get; set; }
        [Inject] public ICategoryClient CategoryClient { get; set; }

        private List<PostDto> PostWithCateGame;
        private CategoryDto GetCateGameHay { get; set; }
        private CategoryDto GetCateTinTucGame { get; set; }
        private List<PostDto> GetTopPost { get; set; }


        protected async override Task OnInitializedAsync()
        {
            PostWithCateGame = await PostClient.GetPostWithCateGame();
            GetCateGameHay = await CategoryClient.GetCateId("6");
            GetCateTinTucGame = await CategoryClient.GetCateId("7");
            GetTopPost = await PostClient.GetTopPost();

        }

    }
}
