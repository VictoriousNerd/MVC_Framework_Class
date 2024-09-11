using ClassAssignements_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignements_Day4.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe" },
            new Student { Id = 2, Name = "Jane Smith" }
        };

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/GetStudent
        public JsonResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return Json(student, JsonRequestBehavior.AllowGet);
        }
    }
}