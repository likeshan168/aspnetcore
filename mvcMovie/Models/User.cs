﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcMovie.Models
{
    public class User
    {
        public int ID { get; set; }

        public string UserName { get; set; } 

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
