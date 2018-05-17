using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LanacHotelaWEBAPI.Startup))]
namespace LanacHotelaWEBAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
