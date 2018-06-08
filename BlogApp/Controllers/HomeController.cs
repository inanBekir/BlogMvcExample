using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            
           
            return View(context.Bloglar.ToList());
        }
    }
}