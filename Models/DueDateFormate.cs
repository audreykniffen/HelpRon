
/*
// Start
#region snippet_1
using System;
using System.ComponentModel.DataAnnotations;
namespace HelpRon.Models
{
    public class Movie
   public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public string Helper { get; set; }
    }
}
#endregion
*/