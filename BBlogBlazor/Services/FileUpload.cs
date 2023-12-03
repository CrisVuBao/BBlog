using BBlogBlazor.Services.IServices;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BBlogBlazor.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebAssemblyHostEnvironment _webAssemblyHostEnvironment;

        public FileUpload(IWebAssemblyHostEnvironment webAssemblyHostEnvironment)
        {
            _webAssemblyHostEnvironment = webAssemblyHostEnvironment;
        }

        public Task<string> UploadFile(IBrowserFile file)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFile(string filePatch)
        {
            throw new NotImplementedException();
        }


    }
}
