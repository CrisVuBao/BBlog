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
        private IBrowserFile? imageFile;
        private IFormFile ImaFile;
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
            try
            {
                ImaFile = new FormFile(e.File.OpenReadStream(e.File.Size), 0, e.File.Size, e.File.Name, e.File.Name);
                var uploadResult = await imageService.AddImageAsync(ImaFile);
                post.PicturePostUrl = uploadResult.SecureUri.ToString();
            }
            catch
            {
                throw;
            }
        }

        private async Task AddPostForm()
        {
            var postContent = await QuillHtml.GetHTML();
            post.Content = postContent;

            var uploadResult = await imageService.AddImageAsync(ImaFile);
            post.PicturePostUrl = uploadResult.SecureUri.ToString();


            if (post.UserId == null) post.UserId = "1";

            var addPost = await PostClient.AddPost(post);



            //if (addPost != null)
            //{
            //    navigationManager.NavigateTo("/");
            //}
            //else
            //{
            //    navigationManager.NavigateTo("/");
            //}

        }
    }
}
