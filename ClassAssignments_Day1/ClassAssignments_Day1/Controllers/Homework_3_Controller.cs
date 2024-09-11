using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments_Day1.Controllers
{
    public class Homework_3_Controller : Controller
    {
        // GET: Homework_3_
        public ActionResult Index()
        {
            ViewData["Message1"] = "This is a ViewData control.";
            ViewBag.Message2 = "This is a ViewBag control.";
            TempData["Message3"] = "This is a TempData control.";

            return View();
        }
    }
}