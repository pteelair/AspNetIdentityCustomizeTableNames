using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02.CustomizeIdentityTutorial.Startup))]
namespace _02.CustomizeIdentityTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
