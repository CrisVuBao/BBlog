using System.ComponentModel.DataAnnotations;

namespace BBlogApi.DTOs
{
	public class RegisterDto : LoginDto
	{
		[Required]
        public string MemberName { get; set; }
	}
}
