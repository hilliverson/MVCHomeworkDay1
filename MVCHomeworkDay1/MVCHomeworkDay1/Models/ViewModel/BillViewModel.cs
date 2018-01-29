using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeworkDay1.Models.ViewModel
{
    

    public class BillViewModel
    {
        public Guid? Id { get; set; }
        public string category { get; set; }
        public decimal money { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
    }
}