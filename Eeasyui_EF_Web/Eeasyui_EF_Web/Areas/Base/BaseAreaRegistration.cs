using System.Web.Mvc;

namespace Eeasyui_EF_Web.Areas.Base
{
    public class SchoolAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Base";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Base_default",
                "Base/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
