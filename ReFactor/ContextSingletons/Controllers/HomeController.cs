using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContextSingletons.Models;
using ContextSingletons.Models.Donkey;
using HttpContextWrapper = ContextSingletons.Models.Donkey.HttpContextWrapper;

namespace ContextSingletons.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DonkeyViewer()
        {
            SmallAss smallAss = new SmallAss(new HttpContextWrapper());
            return View(smallAss);
        }
    }
}
