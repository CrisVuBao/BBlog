﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBlog.Models
{
    public class PostDto
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string BriefContent { get; set; } // mô tả ngắn
        public string Content { get; set; }
        public string PicturePostUrl { get; set; }
        public int OrderNo { get; set; } // thứ tự bài viết, để sắp xếp
        public string TagSearch { get; set; } // từ khóa tìm kiếm, thẻ tag  
        public string PostStatus { get; set; } // trạng thái (bài viết mới tạo, bài viết đang chờ, bài viết bị hủy,...)
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [ForeignKey("TopicDetailId")]
        public int CategoryId { get; set; }
        //public Account AccountUser { get; set; }
    }
}
