using System.Web.Mvc;

namespace RRScheduleManagement.Areas.SupperAdmin
{
    public class SupperAdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SupperAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SupperAdmin_default",
                "SupperAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
