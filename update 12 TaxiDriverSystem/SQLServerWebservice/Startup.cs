using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SQLServerWebservice.Startup))]
namespace SQLServerWebservice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
