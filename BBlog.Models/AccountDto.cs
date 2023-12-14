﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBlog.Models
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string MemberName { get; set; }
        public string InforUser { get; set; }
        public string Avatar { get; set; }
    }
}