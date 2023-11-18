using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBlogApi.Models
{
	public class Account : IdentityUser<int>
	{
		//[Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  //      public int AccountId { get; set; }

        public string MemberName { get; set; }
        public string? InforUser { get; set; }
        public string? Avatar { get; set; }
    }
}
