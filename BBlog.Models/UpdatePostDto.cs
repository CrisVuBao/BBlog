using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBlog.Models
{
    public class UpdatePostDto
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string BriefContent { get; set; } // mô tả ngắn
        public string Content { get; set; }
        public string PicturePostUrl { get; set; }
        public string TagSearch { get; set; } // từ khóa tìm kiếm, thẻ tag     
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }
        public string? UserId { get; set; }
    }
}
