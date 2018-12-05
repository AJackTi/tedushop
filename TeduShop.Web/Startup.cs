using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeduShop.Web.Startup))]
namespace TeduShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
