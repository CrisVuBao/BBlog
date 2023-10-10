using System.ComponentModel.DataAnnotations;

namespace BBlogApi.DTOs
{
	public class RegisterDto
	{
		//[Required(ErrorMessage = "User Name is required")]
		//public string UserName { get; set; }
		[Required(ErrorMessage = "Email is required"), EmailAddress]
		public string Email { get; set; }
		[Required]
        public string MemberName { get; set; }
		[Required(ErrorMessage = "Password is required")]
		public string? Password { get; set; }
	}
}
