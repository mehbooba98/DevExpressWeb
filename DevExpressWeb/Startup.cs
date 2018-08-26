using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevExpressWeb.Startup))]
namespace DevExpressWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
