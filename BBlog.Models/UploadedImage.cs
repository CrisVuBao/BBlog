using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBlog.Models
{
    public class UploadedImage
    {
        public string NewImageFileExtention { get; set; }
        public string NewImageBase64Content { get; set; }
        public string OldImagePath { get; set; }
    }
}
