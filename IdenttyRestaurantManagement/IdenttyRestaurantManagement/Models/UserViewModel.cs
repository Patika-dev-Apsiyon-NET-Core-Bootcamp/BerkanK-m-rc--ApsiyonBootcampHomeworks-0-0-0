﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenttyRestaurantManagement.Models
{
    public class UserViewModel : IdentityUser
    {
        public string UserNm { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
