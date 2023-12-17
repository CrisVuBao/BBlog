﻿using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using BBlogBlazor.Services.IServices;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BBlogBlazor.Layout
{
    public partial class Header 
    {
        [Inject] private ICategoryClient CategoryClient { get; set; }
        [Inject] private IAccountClient AccountClient { get; set; }

        private CategoryDto GetCateId { get; set; }

        private List<CategoryDto> GetAllCate { get; set; }

        //private string navbarClass = "menu-link d-flex fixed-top";

        protected async override Task OnInitializedAsync()
        {
            GetAllCate = await CategoryClient.GetAllCate();
            GetCateId = await CategoryClient.GetCateId("5");
            

            //await JSRuntime.InvokeVoidAsync("window.addEventListener", "scroll", DotNetObjectReference.Create(this), "HandleScroll");
        }

        private async Task Logout()
        {
            await AccountClient.Logout();
            await Swal.FireAsync("Đã đăng xuất tài khoản");
            navigationManager.NavigateTo("/", forceLoad: true);
        }

        //[JSInvokable]
        //public void HandleScroll()
        //{
        //    var scrollY = JSRuntime.InvokeAsync<int>("eval", "window.scrollY");
        //    if (scrollY.Result > 200)
        //    {
        //        navbarClass = "menu-link d-flex blue fixed-top";
        //    }
        //    else
        //    {
        //        navbarClass = "menu-link d-flex red fixed-top";
        //    }
        //    StateHasChanged();
        //}
    }
}
