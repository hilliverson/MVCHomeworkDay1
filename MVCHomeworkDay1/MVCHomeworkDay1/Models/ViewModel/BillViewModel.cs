using MVCHomeworkDay1.Models.Valid;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHomeworkDay1.Models.ViewModel
{
    

    public class BillViewModel
    {
        public Guid? Id { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        [RegularExpression(@"^\+?[1-9][0-9]*$")]
        public decimal money { get; set; }
        
        
        [ValidDateToday]
        [DataType(DataType.Date)]
        [Required]
        public DateTime date { get; set; }
        [Required]
        public string description { get; set; }
    }
}