using System.Web.Mvc;

namespace Voluntariado.Apresentacao.MVC.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Index", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Voluntariado.Apresentacao.MVC.Areas.Admin.Controllers" }
            );
        }
    }
}