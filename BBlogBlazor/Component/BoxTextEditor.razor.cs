using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Blazored.TextEditor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;


namespace BBlogBlazor.Component
{
    public partial class BoxTextEditor
    {
        private string UploadFileWarning = string.Empty;
        private string img = string.Empty;
        private BlazoredTextEditor QuillHtml;
        private string imageType;
        [Inject] private IPostClient PostClient { get; set; }
        [Inject] private ICategoryClient CategoryClient { get; set; }

        List<CategoryDto> categories = new List<CategoryDto>();
        CreatePost post = new CreatePost();

        protected override async Task OnInitializedAsync()
        {
            categories = await CategoryClient.GetAllCate();
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
            var postContent = await QuillHtml.GetHTML();
            post.Content = postContent;


            if (post.UserId == null) post.UserId = "1";

            var addPost = await PostClient.AddPost(post);



            if (addPost != null)
            {
                navigationManager.NavigateTo("/");
            }
            else
            {
                navigationManager.NavigateTo("/");
            }

        }
    }
}
