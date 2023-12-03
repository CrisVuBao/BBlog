using Microsoft.AspNetCore.Components.Forms;

namespace BBlogBlazor.Services.IServices
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);
        Task<bool> DeleteFile(string filePatch);
    }
}
