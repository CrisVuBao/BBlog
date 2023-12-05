using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBlog.Models
{
    public class Register
    {
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CofirmPassword { get; set; }
    }
}
