using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModel
{
    public class CommentViewModel
    {
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public User UserName { get; set; }
        public Blog BlogTitle { get; set; }
    }
}
