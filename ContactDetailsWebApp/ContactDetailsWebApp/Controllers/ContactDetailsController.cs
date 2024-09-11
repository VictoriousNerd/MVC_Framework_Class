using ContactDetailsWebApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Persistence;
using Umbraco.Core.Services.Implement;

namespace ContactDetailsWebApp.Controllers
{
    public class ContactDetailsController : Controller
    {
        // CRUD BEGIN
        // -- Load Dashboard Table
        public ActionResult  Dashboard()
        {
            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
            List<ContactDetails> lstCont = contactDetailsRepository.getContDet();
            ViewBag.UserCount = contactDetailsRepository.GetUserCount();
            ViewBag.MangCount = contactDetailsRepository.GetManagCount();
            ViewBag.EmpCount = contactDetailsRepository.GetEmpCount();
            return View(lstCont);
        }

        // -- Add a new Contact
        public ActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(ContactDetails obj)
        {
            if (ModelState.IsValid)
            {
                ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
                contactDetailsRepository.addContDet(obj);
                ViewBag.Msg = "Contact Details Added Successfully.";
                return View();
            }
            else
            {
                return View(obj);
            }
        }
        // -- Update an existing contact
        public ActionResult UpdateContact(int Id)
        {
            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
            var cont = contactDetailsRepository.getContDet().Find(c => c.Id == Id);
            return View(cont);
        }
        [HttpPost]
        public ActionResult UpdateContact(ContactDetails obj)
        {
            if (ModelState.IsValid)
            {
                ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
                contactDetailsRepository.updateContDet(obj);
                ViewBag.Msg = "Contact Information has been updated successfully.";
                return View();
            }
            else
            {
                return View(obj);
            }   
        }
        // -- Delete a contact
        public ActionResult DeleteContact(int Id)
        {
            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
            contactDetailsRepository.deleteProduct(Id);
            return RedirectToAction("Dashboard");
        }
        //  -- View a single contact
        public ActionResult ViewContact(int Id)
        {
            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
            var cont = contactDetailsRepository.getContDet().Find(c => c.Id == Id);
            return View(cont);
        }
        // END CRUD
    }
}