using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            var conn = new SqlConnection ("sqldev.vaxcare.com;Initial Catalog=Sales;User ID=VxUser;PWD=L0ngP@s$W0r|>$@r3|3es7!");
            conn.Open();

            var cmd = new SqlCommand("SELECT TOP 10 * FROM Orders");
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            sdr.Close();
            //var sda = new SqlDataAdapter(cmd);
            //conn.Close();
            return View();
        }
    }
}
