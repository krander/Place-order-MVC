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
            var myO1 = new OrdersMVC.Models.Order();
            {
                myO1.ID = 123;
                myO1.OrderDate = "03/14/2019 09:33 AM";
                myO1.CustomerId = 100001;
                myO1.Comments = "Please overnight.";

                return View(myO1);
            }
        }
    }
}
