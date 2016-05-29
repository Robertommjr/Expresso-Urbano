using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpressoUrbano.Presentation.Startup))]
namespace ExpressoUrbano.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
