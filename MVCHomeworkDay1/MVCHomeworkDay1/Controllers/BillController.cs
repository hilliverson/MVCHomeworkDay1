using MVCHomeworkDay1.Models;
using MVCHomeworkDay1.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeworkDay1.Controllers
{
    public class BillController : Controller
    {
        // GET: Bill
        public ActionResult Bill()
        {
            List<Bill> list = new List<Bill>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Bill obj = new Bill();
                obj.type = "支出";
                obj.money = random.Next(0, 10000);
                obj.date = DateTime.Now.ToString("yyyy-mm-dd");
                list.Add(obj);
            }
            
            return View(list);
        }
    }
}