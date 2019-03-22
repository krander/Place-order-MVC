using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrdersMVC.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            var O = new OrdersMVC.Models.Orders();
            O.OrdersList = new List<Models.Order>();

            var myO = new OrdersMVC.Models.Order();
            myO.ID = 124;
            myO.OrderDate = "03/22/2019 8:52 AM";
            myO.CustomerId = 100001;
            myO.Comments = "SchoolCares clinic.";
            O.OrdersList.Add(myO);

            var myO2 = new OrdersMVC.Models.Order();
            myO2.ID = 125;
            myO2.OrderDate = "03/22/2019 8:53 AM";
            myO2.CustomerId = 100001;
            myO2.Comments = "Outreach clinic.";
            O.OrdersList.Add(myO2);

            var myO3 = new OrdersMVC.Models.Order();
            myO3.ID = 126;
            myO3.OrderDate = "03/22/2019 8:53 AM";
            myO3.CustomerId = 100001;
            myO3.Comments = "Expected patient volume increase.";
            O.OrdersList.Add(myO3);

            var myO4 = new OrdersMVC.Models.Order();
            myO4.ID = 127;
            myO4.OrderDate = "03/22/2019 8:54 AM";
            myO4.CustomerId = 100001;
            myO4.Comments = "New provider available.";
            O.OrdersList.Add(myO4);

            return View(O.OrdersList);
        }
    }
}
