using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OHS.Startup))]
namespace OHS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
