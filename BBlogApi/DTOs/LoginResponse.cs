namespace BBlogApi.DTOs
{
    public class LoginResponse
    {
        public bool Successful { get; set; }
        public string? Error { get; set; }
        public string? Token { get; set; }
        public AccountDto UserDto { get; set; }
    }
}
