using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreASP.Startup))]
namespace StoreASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
