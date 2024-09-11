using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments_Day1.Controllers
{
    public class Homework_1_Controller : Controller
    {
        // GET: Homework_1_
        public ActionResult Index()
        {
            DateTime now = DateTime.Now;
            ViewBag.CurrentDateTime = now;

            return View();
        }
    }
}