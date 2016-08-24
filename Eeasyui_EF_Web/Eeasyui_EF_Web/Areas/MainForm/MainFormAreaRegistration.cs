using System.Web.Mvc;

namespace Eeasyui_EF_Web.Areas.MainForm
{
    public class MainFormAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MainForm";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MainForm_default",
                "MainForm/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
