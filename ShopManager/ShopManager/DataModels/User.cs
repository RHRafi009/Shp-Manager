﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DataModels
{
    public class User
    {
        public string UserName { get; set; }

        public string  Password { get; set; }

        public string Role { get; set; }

        public string ErrorMessage { get; set; }
    }
}
