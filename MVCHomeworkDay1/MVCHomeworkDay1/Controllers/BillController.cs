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
            AccountBookService accountBook = new AccountBookService();
            return  View(accountBook.Get());
        }
    }
}