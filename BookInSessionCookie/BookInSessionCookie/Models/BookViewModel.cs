using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookInSessionCookie.Models
{
    public class BookViewModel
    {//book değerlerinin tutulacağı VM
        public int Id { get; set; }
        public int YearOfPublish { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
  
    }
}
