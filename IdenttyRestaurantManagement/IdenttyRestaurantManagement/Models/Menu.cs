using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenttyRestaurantManagement.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Food> Foods{ get; set; }//lazyloading kullanıldı. Bir menüde birden fazla yiyecek olabilir
    }
}
