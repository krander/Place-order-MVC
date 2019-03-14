using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrdersMVC.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string Comments { get; set; }
    }
}
