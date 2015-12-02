using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication.Project1.Startup))]
namespace WebApplication.Project1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
