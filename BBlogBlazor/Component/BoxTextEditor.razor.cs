﻿using AngleSharp;
using AngleSharp.Dom;
using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using BBlogBlazor.Static;
using Blazored.TextEditor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using System.Text;
using System.Net;
using System.Net.Http.Json;
using System.Security.Claims;


namespace BBlogBlazor.Component
{
    public partial class BoxTextEditor
    {
        [Inject] HttpClient HttpClient { get; set; }
        private string UploadFileWarning = string.Empty;
        private string img = string.Empty;
        private BlazoredTextEditor BlazoredTextEditor;
        private string imageType;
        [Inject] private IPostClient PostClient { get; set; }
        [Inject] private ICategoryClient CategoryClient { get; set; }
        [Inject] IJSRuntime JSRuntime { get; set; }
        [Inject] AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        private ElementReference _quillJSEditorDiv;

        List<CategoryDto> categories = new List<CategoryDto>();
        PostDto post = new PostDto() { PicturePostUrl = "images/placeholder.png" };
        private string UserId;

        private bool _attemptingToUploadImage = false;
        private bool _attemptingToUploadFailed = false;
        private string _reasonImageUploadFailed = null;

        protected override async Task OnInitializedAsync()
        {
            categories = await CategoryClient.GetAllCate();

            await JSRuntime.InvokeVoidAsync("QuillFunctions.createQuill", _quillJSEditorDiv, true);

            var authenticationState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authenticationState.User;

            if (user.Identity.IsAuthenticated)
            {
                UserId = user.FindFirst("sub")?.Value; // "sub" là claim chứa UserId
            }
        }

        private async Task HandleFileSelect(InputFileChangeEventArgs e)
        {
            _attemptingToUploadImage = true;

            //if (e.File.ContentType != "image/jpeg" && e.File.ContentType != "image/png" && e.File.ContentType != "image/webp")
            if (e.File.ContentType != "image/jpeg" && e.File.ContentType != "image/png" && e.File.ContentType != "image/jpg" && e.File.ContentType != "image/webp")
            {
                _reasonImageUploadFailed = "Vui lòng tải ảnh lên với định dạng JPEG, JPG, hoặc PNG, hoặc WEBP";
                _attemptingToUploadFailed = true;
            }
            else if(e.File.Size >= 31457280) // 31457280 bytes = 30MB
            {
                _reasonImageUploadFailed = "Vui lòng tải lên ảnh nhỏ hơn 30MB";
                _attemptingToUploadFailed = true;
            }
            else
            {
                IBrowserFile uploadedImageFile = e.File;

                byte[] imageAsByteArray = new byte[uploadedImageFile.Size];

                await uploadedImageFile.OpenReadStream(31457280).ReadAsync(imageAsByteArray);
                string byteString = Convert.ToBase64String(imageAsByteArray);

                string fileExtension = Path.GetExtension(uploadedImageFile.Name);

                UploadedImage uploadedImage = new UploadedImage()
                {
                    NewImageFileExtention = fileExtension,
                    NewImageBase64Content = byteString,
                    OldImagePath = string.Empty
                };

                HttpResponseMessage response = await HttpClient.PostAsJsonAsync<UploadedImage>(APIEndpoints.s_imageUpload, uploadedImage);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    post.PicturePostUrl = await response.Content.ReadAsStringAsync();
                }else
                {
                    _reasonImageUploadFailed = $"Xảy ra lỗi khi gọi tới máy chủ. Server Code: {response.StatusCode}. Server reason: {response.ReasonPhrase}";
                    _attemptingToUploadFailed = true;
                }
            }
            _attemptingToUploadImage = false;
            StateHasChanged();
        }

        private async Task AddPostForm()
        {
            post.Content = await JSRuntime.InvokeAsync<string>("QuillFunctions.getQuillContent", _quillJSEditorDiv);

            if (post.UserId == null)
            {
                var authstate = await GetAuthenticationStateAsync.GetAuthenticationStateAsync();
                var user = authstate.User;
                var name = user.Identity.Name;
                post.UserId = name;
            }

            var addPost = await PostClient.AddPost(post);

            if (addPost != null && post.CategoryId != 0)
            {
                await Swal.FireAsync("Tạo bài viết thành công", "Chuyển hướng trong giây lát", "success");
                navigationManager.NavigateTo("/");
            }
            else
            {
                await Swal.FireAsync("Không tạo được bài viết", "Kiểm tra có thiếu sót gì không!", "error");
            }

        }
    }
}
