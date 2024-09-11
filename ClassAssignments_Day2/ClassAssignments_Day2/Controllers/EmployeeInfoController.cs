using ClassAssignments_Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments_Day2.Controllers
{
    public class EmployeeInfoController : Controller
    {
        // GET: EmployeeInfo
        public ActionResult Register()
        {
            return View();
        }

        // POST: Employee/RegisterEmployee
        [HttpPost]
        public ActionResult RegisterEmployee(EmployeeInfo employee)
        {

            return RedirectToAction("Success", employee);
        }

        // GET: Employee/Success
        public ActionResult Success(EmployeeInfo employee)
        {
            return View(employee);
        }

    }
}