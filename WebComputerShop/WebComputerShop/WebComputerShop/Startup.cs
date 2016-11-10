using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebComputerShop.Startup))]
namespace WebComputerShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
