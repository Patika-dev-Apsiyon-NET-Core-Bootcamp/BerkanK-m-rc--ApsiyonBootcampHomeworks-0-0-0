using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenttyRestaurantManagement.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string FoodName { get; set; }
        public virtual ICollection<Category> Categories { get; set; }//bir yemek birden fazla kategoriye ait olabilir
    }
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Menu> Menus { get; set; }//lazy oloading kullanılmıcak, bir restaurant ta birden fazla menu olabilir
    }
}
