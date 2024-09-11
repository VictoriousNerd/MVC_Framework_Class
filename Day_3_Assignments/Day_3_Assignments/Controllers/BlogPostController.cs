using Day_3_Assignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_3_Assignments.Controllers
{
    public class BlogPostController : Controller
    {
        private MockBlogRepository _repository = new MockBlogRepository();

        public ActionResult Index()
        {
            var blogPosts = _repository.GetBlogPosts();
            return View(blogPosts);
        }

    }
}  