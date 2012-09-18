using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMVCFiltersTest.Common
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute
    {


        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (SessionHandler.EntryID != null)
            {
                return true;
            }

            return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Home" }, { "action", "Index" } });


        }

    }
}