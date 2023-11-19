using Microsoft.JSInterop;

namespace BBlogBlazor.Layout
{
    public partial class Header 
    {
        private string navbarClass = "menu-link d-flex fixed-top";

        protected override async Task OnInitializedAsync()
        {
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
