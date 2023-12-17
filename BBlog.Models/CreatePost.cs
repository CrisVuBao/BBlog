using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BBlog.Models
{
    public class CreatePost
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string BriefContent { get; set; } // mô tả ngắn
        public string Content { get; set; }
        public string PictureUrlData { get; set; }
        public string PictureUrlOriginal { get; set; }

        public string TagSearch { get; set; } // từ khóa tìm kiếm, thẻ tag  

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public int ViewCount { get; set; }

        [ForeignKey("TopicDetailId")]
        public int CategoryId { get; set; }
        public string? UserId { get; set; }
        public string? PublicId { get; set; }

    }
}
