using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassAssignments_Day2.Models;

namespace ClassAssignments_Day2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Doe", Position = "Developer", Salary = 50000},
                new Employee { Id = 2, Name = "Jane Smith", Position = "Manager", Salary = 75000},
                new Employee { Id = 3, Name = "Mark Johnson", Position = "Designer", Salary = 60000}
            };
            return View(employees);
        }
    }
}