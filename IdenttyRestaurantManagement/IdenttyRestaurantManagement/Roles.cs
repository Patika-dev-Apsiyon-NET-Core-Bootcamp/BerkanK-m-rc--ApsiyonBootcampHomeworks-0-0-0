using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace IdenttyRestaurantManagement
{
    public static class Roles
    {
        public const string Chef = "CHEF";
    }
    public enum ROLES_TYPES : byte
    {
        [Description(Roles.Chef)]
        Chef = 1,
    }
}