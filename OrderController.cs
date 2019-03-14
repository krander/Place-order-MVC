using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrdersMVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            var myO = new OrdersMVC.Models.Order();
            {
                Console.WriteLine(myO.ID = 123);
                Console.WriteLine(myO.OrderDate = "03/14/2019 09:33 AM");
                Console.WriteLine(myO.CustomerId = 100001);
                Console.WriteLine(myO.Comments = "Please overnight.");

                return View();
            }
        }
    }
}
