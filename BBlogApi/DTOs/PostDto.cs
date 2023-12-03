using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BBlogApi.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BBlogApi.DTOs
{
	public class PostDto
	{
        public int PostId { get; set; }
        public string Title { get; set; }
		public string BriefContent { get; set; } // mô tả ngắn
        public string Content { get; set; }

		[BindNever]
        public string PicturePostUrl { get; set; }
		public string TagSearch { get; set; } // từ khóa tìm kiếm, thẻ tag  
		public string PostStatus { get; set; } // trạng thái (bài viết mới tạo, bài viết đang chờ, bài viết bị hủy,...)
		public DateTime CreateDate { get; set; } = DateTime.Now;

		[ForeignKey("TopicDetailId")]
		public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        //public Account AccountUser { get; set; }
    }
}
