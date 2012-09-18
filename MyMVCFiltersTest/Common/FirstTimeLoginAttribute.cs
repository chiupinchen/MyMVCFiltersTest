using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCFiltersTest.Common
{
    public class FirstTimeLoginAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //CIAccount cIAccount = new CIAdminAccount();

            //if (cIAccount.IsFirstTimeLoginOrResetUser())
            //    filterContext.Result = RouteHelper.ToChangePassword();
        }
    }
}