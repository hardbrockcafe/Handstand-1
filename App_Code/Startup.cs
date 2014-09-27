using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Handstand.Startup))]
namespace Handstand
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
