using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCFiltersTest.Common
{
    public class ExcludeFilterAttribute : ActionFilterAttribute
    {
        //by using param4, we allow mutiple attributes to be passed in to be in the exclude list
        public ExcludeFilterAttribute(params Type[] toExcludes)
        {
            FilterToExclude = toExcludes as IList<Type>; //explicitly cast
        }

        /// <summary>
        /// The type of filter that will be ignored.
        /// </summary>
        public IList<Type> FilterToExclude
        {
            get;
            private set;
        }
    }
}