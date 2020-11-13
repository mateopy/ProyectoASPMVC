using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoASPMVC.Startup))]
namespace ProyectoASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
