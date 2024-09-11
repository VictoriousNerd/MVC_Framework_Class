using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTfulAPI_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public decimal Price { get; set; }

    }
}