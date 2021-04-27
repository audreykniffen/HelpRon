
using System;
using System.ComponentModel.DataAnnotations;

namespace HelpRon.Models
{
    public class DueDate
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime dueDate { get; set; }
        public string Helper { get; set; }
    
    }
}
