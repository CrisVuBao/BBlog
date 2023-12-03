using BBlogApi.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ImageUploadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> PostImage([FromBody] UploadImageExtention uploadImage)
        {
            try
            {
                if (ModelState.IsValid == false) return BadRequest(ModelState);

                if (uploadImage.OldImagePath != string.Empty)
                {
                    if (uploadImage.OldImagePath != "images/drag-drop-upload-2.webp")
                    {
                        string oldUploadImageFileName = uploadImage.OldImagePath.Split('/').Last();

                        System.IO.File.Delete($"{_webHostEnvironment.ContentRootPath}\\images\\products\\{oldUploadImageFileName}");
                    }
                }

                string guid = Guid.NewGuid().ToString();
                string imageFileName = guid + uploadImage.NewImageFileExtenstion;

                string fullImageFileSystemPath = $"{_webHostEnvironment.ContentRootPath}\\images\\products\\{imageFileName}";

                FileStream fileStream = System.IO.File.Create(fullImageFileSystemPath);
                byte[] imageContentAsByteArray = Convert.FromBase64String(uploadImage.NewImageBase64Content);
                await fileStream.WriteAsync(imageContentAsByteArray, 0, imageContentAsByteArray.Length);
                fileStream.Close();

                string relativeFilePathWithoutTrailingSlashes = $"images/{imageFileName}";
                return Created("Create", relativeFilePathWithoutTrailingSlashes);

            } catch(Exception e)
            {
                return StatusCode(500, $"Có lỗi xảy ra, liên hệ admin để được giúp đỡ. Error Message: {e.Message}");
            }
        }
    }
}
