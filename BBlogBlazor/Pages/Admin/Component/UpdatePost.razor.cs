using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Blazored.TextEditor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BBlogBlazor.Pages.Admin.Component
{
    public partial class UpdatePost
    {
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
        CreatePost post = new CreatePost();
        private string UserId;

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
            var file = e.File;
            if (file != null)
            {
                var ext = System.IO.Path.GetExtension(file.Name);
                if (ext.ToLower().Contains("jpg") || ext.ToLower().Contains("png") || ext.ToLower().Contains("jpeg") || ext.ToLower().Contains("webp"))
                {
                    var byteArray = new byte[file.Size];
                    await file.OpenReadStream().ReadAsync(byteArray);
                    string imageType = file.ContentType;
                    string base64String = Convert.ToBase64String(byteArray);

                    post.PictureUrlData = base64String;
                    post.PictureUrlOriginal = file.Name;
                    img = $"data:{imageType}; base64, {base64String}";
                }
                else
                {
                    UploadFileWarning = "Cần chọn file (*.ipg | *.png | *.jpeg | *.webp)";
                }
            }
        }

        private async Task AddPostForm()
        {
            post.Content = await JSRuntime.InvokeAsync<string>("QuillFunctions.getQuillContent", _quillJSEditorDiv);

            if (post.UserId == null)
            {
                post.UserId = "1";
            }

            var addPost = await PostClient.AddPost(post);

            if (addPost != null && post.PostId > 0)
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
