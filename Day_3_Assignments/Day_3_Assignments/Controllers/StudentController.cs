using Day_3_Assignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_3_Assignments.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Student/Register
        [HttpPost]
        public ActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                // Redirect to a success page or home page
                return RedirectToAction("Index", "Home");
            }

            // If model validation fails, return to the same view with errors
            return View(student);
        }

    }
}