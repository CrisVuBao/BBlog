using System.ComponentModel.DataAnnotations;

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
