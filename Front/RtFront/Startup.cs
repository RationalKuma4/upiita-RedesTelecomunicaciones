using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RtFront.Startup))]
namespace RtFront
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
