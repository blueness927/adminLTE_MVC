using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageSystem_MVC.Startup))]
namespace ManageSystem_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
