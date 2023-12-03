using BBlogApi.Models;

namespace BBlogApi.DTOs
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public List<Post> Post { get; set; }
    }
}
