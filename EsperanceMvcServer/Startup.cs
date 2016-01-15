using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EsperanceMvcServer.Startup))]
namespace EsperanceMvcServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
