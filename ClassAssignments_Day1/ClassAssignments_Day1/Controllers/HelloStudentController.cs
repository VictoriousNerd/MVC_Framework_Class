using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments_Day1.Controllers
{
    public class HelloStudentController : Controller
    {
        // GET: HelloStudent
        public ActionResult Index()
        {
            ViewBag.Title = "Hello World!";
            TempData["student_name"] = "Victor";
            return View();
        }
    }
}