using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveShare_Server.Startup))]
namespace LiveShare_Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
