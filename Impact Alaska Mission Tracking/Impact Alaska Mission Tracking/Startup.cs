using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Impact_Alaska_Mission_Tracking.Startup))]
namespace Impact_Alaska_Mission_Tracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
