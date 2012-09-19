using System.Web.Mvc;

namespace MyMVCFiltersTest.Areas.IPad
{
    public class IPadAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "IPad";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "IPad_default",
                "IPad/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
