

using BBlogApi.Services.IServices;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace BBlogApi.Services
{
    public class ImageService
    {
        public static Cloudinary _cloudinary;

        public const string CLOUD_NAME = "dw8k0tnwn";
        public const string API_KEY = "542552499875222";
        public const string API_SECRET = "I0Trl4te0NWAqBuA7FqptNUwFbQ";

        public ImageService()
        {
            Account account = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            _cloudinary = new Cloudinary(account);
        }

        public async Task<ImageUploadResult> AddImageAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();

            if (file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream)
                };
                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }

            return uploadResult;
        }

        public async Task<DeletionResult> DeleteImageAsync(string publicId)
        {
            var deleteParams = new DeletionParams(publicId);

            var result = await _cloudinary.DestroyAsync(deleteParams);

            return result;
        }
    }
}
