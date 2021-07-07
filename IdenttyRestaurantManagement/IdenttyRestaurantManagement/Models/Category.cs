using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenttyRestaurantManagement.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Category_Name { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }//lazy loading, bir categoride birden fazla menu olabilir.
    }
}
