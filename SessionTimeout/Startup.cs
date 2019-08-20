using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SessionTimeout.Startup))]
namespace SessionTimeout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
