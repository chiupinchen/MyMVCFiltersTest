using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCFiltersTest.Common;
using MyMVCFiltersTest.Controllers;

namespace MyMVCFiltersTest.Areas.IPad.Controllers
{
    public class ProcessController : HomeController
    {
        //
        // GET: /IPad/Process/
        [ExcludeFilter(typeof(AdminAuthorizeAttribute))]
        public ActionResult Index2()
        {
            return View();
        }

        public override ActionResult About()
        {

            return RedirectToAction("LogOn", "Account", new { area = "" });
        }

    }
}
