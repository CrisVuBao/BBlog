using BBlog.Models;

namespace BBlogBlazor.Services.IRepository
{
    public interface ICategoryClient
    {
        Task<CategoryDto> GetCateId(string id);
    }
}
