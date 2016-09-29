using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mission_Tracking.Startup))]
namespace Mission_Tracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
