using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModel
{
    public class TagViewModel
    {
        public int TagID { get; set; }
        public string TagName { get; set; }

        public List<int> SelectedTags { get; set; }
    }
}
