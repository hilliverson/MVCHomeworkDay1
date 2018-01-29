using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeworkDay1.Service
{
    public class AccountBook
    {
        public Guid? Id { get; set; }
        public int Categoryyy { get; set; }
        public decimal Amounttt { get; set; }
        public DateTime Dateee { get; set; }
        public string Remarkkk { get; set; }
    }
}