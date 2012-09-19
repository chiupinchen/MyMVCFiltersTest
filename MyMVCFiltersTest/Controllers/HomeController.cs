using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCFiltersTest.Common;

namespace MyMVCFiltersTest.Controllers
{
    public class HomeController : Controller
    {
        [ExcludeFilter(typeof(AdminAuthorizeAttribute))]
        public ActionResult Index(bool? LogInError)
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewBag.LogInError = LogInError;
            return View();
        }

        [ExcludeFilter(typeof(AdminAuthorizeAttribute))]
        public ActionResult SetSession(string EntryID1, FormCollection fc)
        {

            var p = Request.Form["abc"];

            if (EntryID1 != "") { 
                SessionHandler.EntryID = EntryID1;
                return RedirectToAction("About");
            }

            return RedirectToAction("Index", new { LogInError =true });
        }
        
        public ActionResult RemoveSession()
        {
            SessionHandler.EntryID = null;
            return View();
        }

        [ExcludeFilter(typeof(AdminAuthorizeAttribute))]
        public ActionResult AjaxSetSession(string EntryID2)
        {
           
            SessionHandler.EntryID = EntryID2;
            return Content("Session Has been set", "text/html");
        }

        
        public virtual ActionResult About()
        {
            return View();
        }

        //[ExcludeFilter(typeof(AdminAuthorizeAttribute), typeof(FirstTimeLoginAttribute))]
        //public ActionResult About1()
        //{
        //    return View();
        //}
    }
}
