
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace HelpRon.Models
{
    public class NeedHelperViewModel
    {
        
        
        public List<Need> Needs { get; set; }
        public SelectList Helper { get; set; }
        public string NeedHelper { get; set; }
        public string SearchString { get; set; }
    }
      
}