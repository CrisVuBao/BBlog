using BBlog.Models;

namespace BBlogBlazor.Services.IServices
{
    public interface IAccountClient
    {
        Task<List<AccountDto>> GetAllUser();
    }
}
