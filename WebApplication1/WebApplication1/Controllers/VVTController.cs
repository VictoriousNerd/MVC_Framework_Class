using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class VVTController : Controller
    {
        // GET: VVT
        public ActionResult Index()
        {
            ViewBag.Title = "Victor";
            ViewData["StudentName"] = "Peter";
            TempData["Students"] = "Victor and Peter";
            return View();
        }
    }
} 