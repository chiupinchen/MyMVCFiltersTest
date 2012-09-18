using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCFiltersTest.Common
{
    public class SessionHandler
    {
        public static string EntryID
        {
            get
            {
                if (HttpContext.Current.Session["EntryID"] == null)
                {
                    return null;
                }
                else
                {
                    return HttpContext.Current.Session["EntryID"] as string;
                }
            }
            set
            {
                HttpContext.Current.Session["EntryID"] = value;
            }
        }
    }
}