using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EP.CursoMVC.UI.MVC.Startup))]
namespace EP.CursoMVC.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
