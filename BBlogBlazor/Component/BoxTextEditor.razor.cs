using BBlog.Models;
using BBlogApi.Extensions;
using BBlogBlazor.Services.IRepository;
using Blazored.TextEditor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System.Net.Http.Json;


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


        private bool _attemptingToUploadImage = false;
        private bool _attempToUploadFailed = false;
        private string _reasonImageUploadFailed = null;

        private async Task HandleFileSelect(InputFileChangeEventArgs e)
        {
            using var httpClient = new HttpClient();

            _attemptingToUploadImage = true;
            if (e.File.Size >= 31575280)
            {
                _reasonImageUploadFailed = "Cần upload ảnh nhỏ hơn 30MB";
                _attempToUploadFailed = true;
            } else
            {
                imageFile = e.File;
                byte[] imageAsByteArray = new byte[imageFile.Size];

                await imageFile.OpenReadStream(31575280).ReadAsync(imageAsByteArray);
                string byteString = Convert.ToBase64String(imageAsByteArray);

                UploadImage uploadedImage = new UploadImage()
                {
                    NewImageFileExtenstion = imageFile.Name.Substring(imageFile.Name.Length - 4),
                    NewImageBase64Content = byteString,
                    OldImagePath = string.Empty
                };

               HttpResponseMessage response =  await httpClient.PostAsJsonAsync<UploadImage>("api/ImageUpload", uploadedImage);
                if(response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    post.PicturePostUrl = await response.Content.ReadAsStringAsync();
                }else
                {
                    _reasonImageUploadFailed = "lỗi gì đó khi yêu cầu từ server";
                    _attempToUploadFailed = true;
                }

                _attemptingToUploadImage = false;
                StateHasChanged();
            }
        }

        private async Task AddPostForm()
        {
            var postContent = await QuillHtml.GetHTML();
            post.Content = postContent;


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
