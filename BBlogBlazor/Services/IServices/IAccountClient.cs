using BBlog.Models;

namespace BBlogBlazor.Services.IServices
{
    public interface IAccountClient
    {
        Task<List<AccountDto>> GetAllUser();
        Task<LoginResponse> Login(LoginDto login);
        Task<RegisterResponse> Register(RegisterDto register);
        Task Logout();
    }
}
