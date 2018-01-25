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
            //List<BillViewModel> list = new List<BillViewModel>();
            //Random random = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    BillViewModel obj = new BillViewModel();
            //    obj.type = "支出";
            //    obj.money = random.Next(0, 10000);
            //    obj.date = DateTime.Now.ToString("yyyy-MM-dd");
            //    list.Add(obj);
            //}
            AccountBookService accountBook = new AccountBookService();
            var list = accountBook.Get();
            List<BillViewModel> ViewList = new List<BillViewModel>();
            foreach (var item in list)
            {
                BillViewModel obj = new BillViewModel();
                obj.type = Convert.ToString(item.Categoryyy);
                obj.money = item.Amounttt;
                obj.date = item.Dateee.ToString("yyyy-MM-dd");
                ViewList.Add(obj);

            }


            return View(list);
        }
    }
}