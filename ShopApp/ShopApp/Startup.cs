using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopApp.Startup))]
namespace ShopApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
