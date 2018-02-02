using MVCHomeworkDay1.Models.ViewModel;
using MVCHomeworkDay1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeworkDay1.Controllers
{
    public enum CategorySelect
    {
        支出 = 0,
        收入 = 1
    };

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Category"] = SetCategorySelectList();
            return View();
        }

        private static List<SelectListItem> SetCategorySelectList()
        {
            var items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "支出", Value = "0" });
            items.Add(new SelectListItem { Text = "收入", Value = "1" });
            return items;
        }

        [HttpPost]
        public ActionResult Index(BillViewModel InputData)
        {
            ViewData["Category"] = SetCategorySelectList();
            AccountBookService accountBook = new AccountBookService();
            accountBook.Insert(InputData);

            return View(InputData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Bill()
        {
            AccountBookService accountBook = new AccountBookService();
            return View(accountBook.Get());
        }
    }
}