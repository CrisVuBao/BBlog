using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBlogApi.Models
{
	public class Categories
	{
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public List<Post> Post { get; set; }
	}
}
