﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBlog.Models
{
    public class RegisterResponse
    {
        public bool RegisterSuccessful { get; set; }
        public string? Error { get; set; }
    }
}
