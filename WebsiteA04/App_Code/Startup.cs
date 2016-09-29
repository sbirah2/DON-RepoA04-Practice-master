using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteA04.Startup))]
namespace WebsiteA04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
