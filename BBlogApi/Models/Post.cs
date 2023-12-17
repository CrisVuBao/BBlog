using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBlogApi.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string BriefContent { get; set; } // mô tả ngắn
        public string Content { get; set; }
        public string PicturePostUrl { get; set; }
        public string TagSearch { get; set; } // từ khóa tìm kiếm, thẻ tag  

        [BindNever]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [BindNever]
        public int ViewCount { get; set; }
        public string? UserId { get; set; }
        public string? PublicId { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }
        public int CategoryId { get; set; }
        //public Account AccountUser { get; set; }
    }
}
