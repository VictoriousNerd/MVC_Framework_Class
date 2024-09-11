using ContactDetailsWebApp.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactDetailsWebApp.Controllers
{
    public class AccountController : Controller
    {
 
        public SqlConnection Con;

        public void Conect()
        {
            string strCon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            Con = new SqlConnection(strCon);
        }
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string emailaddress, string password)
        {
            Conect();
            Con.Open();
            var user = Con.QueryFirstOrDefault<ContactDetails>("SELECT * FROM ContactDetails WHERE EmailAddress = @EmailAddress AND Password = @Password",
                new { EmailAddress = emailaddress, Password = password });

            if (user != null)
            {
                return RedirectToAction("Dashboard", "ContactDetails");
            }
            else
            {
                ModelState.AddModelError("", "Invalid email address or password.");
                return View();
            }
        }
    }
}