using ProductDatabaseForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductDatabaseForm.Controllers
{
    public class ProductController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ProdRepository prodRepository = new ProdRepository();
            List<Product> lstProd = prodRepository.getProduct();
            return View(lstProd);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product obj)
        {
            ProdRepository prodRepository = new ProdRepository();
            prodRepository.AddProduct(obj);
            ViewBag.Msg = "Product Information Add Successfully.";

            return View();
        }

        public ActionResult Edit(int Id)
        {
            ProdRepository prodRepository = new ProdRepository();
            var prod=prodRepository.getProduct().Find(p=>p.Id == Id);
            return View(prod);
        }

        [HttpPost]
        public ActionResult Edit(Product obj)
        {
            ProdRepository prodRepository = new ProdRepository();
            prodRepository.UpdateProduct(obj);
            ViewBag.Msg = "Product Information updated successfully.";
            return View();
        }

        public ActionResult Delete(int Id)
        {
            ProdRepository prodRepository = new ProdRepository();
            prodRepository.deleteProduct(Id);
            return RedirectToAction("Index");
        }

        public ActionResult View(int Id)
        {
            ProdRepository prodRepository = new ProdRepository();
            var prod = prodRepository.getProduct().Find(p => p.Id == Id);
            return View(prod);
        }

    }
}