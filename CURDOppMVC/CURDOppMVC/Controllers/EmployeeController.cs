using CURDOppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CURDOppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmpRepository empRepository = new EmpRepository();
            List<Employee> lstEmp=empRepository.getEmps();  
            return View(lstEmp);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee obj)
        {
            EmpRepository empRepository=new EmpRepository();
            empRepository.addEmp(obj);
            ViewBag.Msg = "Employee Information Add Successfully.";

            return View();
        }
    }
}