using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BBlogBlazor.Layout
{
    public partial class Header 
    {
        [Inject] public ICategoryClient CategoryClient { get; set; }
        private CategoryDto GetCateId { get; set; }

        private string navbarClass = "menu-link d-flex fixed-top";

        protected async override Task OnInitializedAsync()
        {
            GetCateId = await CategoryClient.GetCateId("7");
            await JSRuntime.InvokeVoidAsync("window.addEventListener", "scroll", DotNetObjectReference.Create(this), "HandleScroll");
        }

        [JSInvokable]
        public void HandleScroll()
        {
            var scrollY = JSRuntime.InvokeAsync<int>("eval", "window.scrollY");
            if (scrollY.Result > 200)
            {
                navbarClass = "menu-link d-flex blue fixed-top";
            }
            else
            {
                navbarClass = "menu-link d-flex red fixed-top";
            }
            StateHasChanged();
        }
    }
}
