using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CZBK.ItcastOA.WebApp.Startup))]
namespace CZBK.ItcastOA.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
