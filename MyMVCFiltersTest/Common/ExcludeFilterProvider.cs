using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCFiltersTest.Common
{
    public class ExcludeFilterProvider : IFilterProvider
    {
        private FilterProviderCollection filterProviders;

        public ExcludeFilterProvider(IFilterProvider[] filters)
        {
            this.filterProviders = new FilterProviderCollection(filters);
        }


        public IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            //all work in LINQ and IEnumerable to minimize the performance impact 

            //get all filters
            IEnumerable<Filter> allFilters = this.filterProviders.GetFilters(controllerContext, actionDescriptor);


            //get excluding attributes
            IEnumerable<Type> filterTypesToRemove2 = (from f in allFilters
                                                      where f.Instance is ExcludeFilterAttribute
                                                      select (f.Instance as ExcludeFilterAttribute).FilterToExclude as IEnumerable<Type>)
                                                      .SelectMany<IEnumerable<Type>, Type>(typeList => typeList);




            //take out the attributes passed in the exclude filter out of all filters and the exclude filter itself
            IEnumerable<Filter> res = (from filter in allFilters
                                       where !filterTypesToRemove2.Contains<Type>(filter.Instance.GetType()) && !(filter.Instance is ExcludeFilterAttribute)
                                       select filter);


            return res;
        }
    }
}