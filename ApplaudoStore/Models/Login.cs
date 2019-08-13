﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplaudoStore.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
