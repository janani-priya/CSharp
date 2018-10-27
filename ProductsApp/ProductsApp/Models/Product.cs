using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Product
    {

        public int id { get; set; }
        public string name { get; set; }
        public string catergory { get; set; }
        public decimal price { get; set; }
    }
}