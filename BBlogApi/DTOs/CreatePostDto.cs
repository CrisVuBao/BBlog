using BBlogApi.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBlogApi.DTOs
{
    public class CreatePostDto
    {
        public string Title { get; set; }
        public string BriefContent { get; set; } // mô tả ngắn
        public string Content { get; set; }
        public string PictureUrlData { get; set; }
        public string PictureUrlOriginal { get; set; }

        public string TagSearch { get; set; } // từ khóa tìm kiếm, thẻ tag     
        
        [BindNever]       
        public DateTime CreateDate { get; set; } = DateTime.Now;
        
        [BindNever]         
        public int ViewCount { get; set; }

        [ForeignKey("TopicDetailId")]
        public int CategoryId { get; set; }
        public string? UserId { get; set; }
        public string? PublicId { get; set; }

    }
}
