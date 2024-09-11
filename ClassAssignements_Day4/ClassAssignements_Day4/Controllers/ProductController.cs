using ClassAssignements_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignements_Day4.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Lamp", Price = 100, Category = "Furniture" },
                new Product { Id = 2, Name = "Tshirt", Price = 200, Category = "Clothing" },
                new Product { Id = 3, Name = "Chair", Price = 150, Category = "Furniture" }
            };
        }
        public ActionResult GetProduct()
        {
            var products = GetSampleProducts();
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            var obj = new List<Product>
            {
                new Product { Id = 1, Name = "Lamp", Price = 100, Category = "Furniture" },
                new Product { Id = 2, Name = "Tshirt", Price = 200, Category = "Clothing" },
                new Product { Id = 3, Name = "Chair", Price = 150, Category = "Furniture" }
            };

            return View(obj);
        }
    }
}