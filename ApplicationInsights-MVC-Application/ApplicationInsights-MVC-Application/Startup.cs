using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationInsights_MVC_Application.Startup))]
namespace ApplicationInsights_MVC_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
