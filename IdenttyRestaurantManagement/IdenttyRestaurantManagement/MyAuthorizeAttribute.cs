using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenttyRestaurantManagement
{
    public class MyAuthorizeAttribute : AuthorizeAttribute
    {
        public MyAuthorizeAttribute(params string[] roles)
        {

            Roles = string.Join(",", roles);
        }
    }
}
