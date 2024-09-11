using Day_3_Assignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_3_Assignments.Controllers
{
    public class StudentRegController : Controller
    {
        // GET: StudentReg
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(StudentReg model)
        {
            if (ModelState.IsValid)
            {
                // Registration successful, redirect to success page
                return RedirectToAction("Success", model);
            }
            // If model state is not valid, return to the registration page with errors
            return View("Index", model);
        }

        public ActionResult Success(StudentReg model)
        {
            return View(model);
        }

    }
}