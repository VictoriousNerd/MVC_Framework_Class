using ClassAssignements_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignements_Day4.Controllers
{
    public class StudentDetailsController : Controller
    {
        // GET: StudentDetails
        public ActionResult Index()
        {
            return View();
        }

        // POST: Save
        [HttpPost]
        public ActionResult Save(StudentDetails student)
        {
            // Save student details (in this example, we just return the student data)
            return Json(student);
        }

        public ActionResult DisplayDetails(StudentDetails student) 
        { 
            return View(student); 
        }

    }
}