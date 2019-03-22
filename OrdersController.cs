using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            var conn = new SqlConnection("data source=sqldev.vaxcare.com;Initial Catalog=Sales;User ID=VxUser;PWD=L0ngP@s$W0r|>$@r3|3es7!");
            var cmd = new SqlCommand("SELECT TOP 10 OrderID, Placed, ClinicID, OrderReason FROM Sales.Dbo.Orders");
            cmd.Connection = conn;

            conn.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                var myOs = new OrdersMVC.Models.Order();
                myOs.ID = Convert.ToInt32(reader["OrderID"]);
                myOs.OrderDate = Convert.ToString(reader["Placed"]);
                myOs.CustomerId = Convert.ToInt32(reader["ClinicID"]);
                myOs.Comments = Convert.ToString(reader["OrderReason"]);
                O.OrdersList.Add(myOs);
            }
            
            conn.Close();

            return View(O.OrdersList);
        }
    }
}
