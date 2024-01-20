using BBlog.Models;
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
        public async Task<IActionResult> AddUploadImage([FromBody] UploadedImage uploadedImage)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    return BadRequest(ModelState);
                }

                if (uploadedImage.OldImagePath != string.Empty)
                {
                    if(uploadedImage.OldImagePath != "images/placeholder.png")
                    {
                        string oldUploadedImageFileName = uploadedImage.OldImagePath.Split('/').Last();

                        System.IO.File.Delete($"{_webHostEnvironment.ContentRootPath}\\wwwroot\\images\\products\\{oldUploadedImageFileName}");
                    }
                }

                string guid = Guid.NewGuid().ToString();
                string imageFileName = guid + uploadedImage.NewImageFileExtention;

                string fullImageFileSystemPath = $"{_webHostEnvironment.ContentRootPath}\\wwwroot\\images\\products\\{imageFileName}";

                FileStream fileStream = System.IO.File.Create(fullImageFileSystemPath);
                byte[] imageContentAsByteArray = Convert.FromBase64String(uploadedImage.NewImageBase64Content);
                await fileStream.WriteAsync(imageContentAsByteArray, 0, imageContentAsByteArray.Length);
                fileStream.Close();

                string relativeFilePathWithoutTrailingSlashes = $"images/products/{imageFileName}";
                return Created("Create", relativeFilePathWithoutTrailingSlashes);
            }catch(Exception ex)
            {
                return StatusCode(500, $"Có lỗi gì đó. Hãy liên hệ với Admin để được hỗ trợ. Error Message: {ex.Message}");
            }
        }

    }
}
