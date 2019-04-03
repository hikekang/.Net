using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_91_5.Startup))]
namespace _91_5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
