using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeworkDay1.Models.ViewModel
{
    

    public class BillViewModel
    {
        public Guid? Id { get; set; }
        public string Categoryyy { get; set; }
        public decimal Amounttt { get; set; }
        public DateTime Dateee { get; set; }
        public string Remarkkk { get; set; }
    }
}