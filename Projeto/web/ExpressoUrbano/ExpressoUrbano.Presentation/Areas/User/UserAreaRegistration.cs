using System.Web.Mvc;

namespace ExpressoUrbano.Presentation.Areas.User
{
    public class UserAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "User"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "User_default",
                "User/{controller}/{action}/{id}",
                new {controller = "Index", action = "Index", id = UrlParameter.Optional},
                new[] { "ExpressoUrbano.Presentation.Areas.User.Controllers" }
                );
        }
    }
}