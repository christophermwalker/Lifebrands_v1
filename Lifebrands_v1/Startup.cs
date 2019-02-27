using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lifebrands_v1.Startup))]
namespace Lifebrands_v1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
