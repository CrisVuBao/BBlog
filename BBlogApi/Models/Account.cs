using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BBlogApi.Models
{
	public class Account : IdentityUser<int>
	{
        public string MemberName { get; set; }
        public string? InforUser { get; set; }
        public string? Avatar { get; set; }
    }
}
