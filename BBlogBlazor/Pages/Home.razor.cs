using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;

namespace BBlogBlazor.Pages
{
    public partial class Home
    {
        [Inject] public IPostClient PostClient { get; set; }
        [Inject] public ICategoryClient CategoryClient { get; set; }

        private List<PostDto> PostAll { get; set; }
        private PostDto NewsMain { get; set; }
        private PostDto NewsMainSecon { get; set; }
        private PostDto NewsBottomOne { get; set; }
        private PostDto NewsBottomTwo { get; set; }
        private PostDto NewsBottomThree { get; set; }
        private List<PostDto> GetTopPost { get; set; }

        protected async override Task OnInitializedAsync()
        {
            PostAll = await PostClient.GetPostAll();
            NewsMain = await PostClient.GetPostDetail("12");
            NewsMainSecon = await PostClient.GetPostDetail("8");
            NewsBottomOne = await PostClient.GetPostDetail("9");
            NewsBottomTwo = await PostClient.GetPostDetail("3");
            NewsBottomThree = await PostClient.GetPostDetail("11");
            GetTopPost = await PostClient.GetTopPost();
        }
    }
}
