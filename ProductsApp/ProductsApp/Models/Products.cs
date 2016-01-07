using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Products
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Category { set; get; }
        public decimal Price { set; get; }
    }
}