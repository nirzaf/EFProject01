using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFProject01.Startup))]
namespace EFProject01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
