using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassAssignements_Day4.Models;
using System.Web.Security;

namespace ClassAssignements_Day4.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model) 
        {
            if(ModelState.IsValid)
            {
                if (model.UserName.ToLower() == "admin" && model.Password == "admin")
                {
                    Session["UserName"] = model.UserName;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid User Name or Password");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

    }
}