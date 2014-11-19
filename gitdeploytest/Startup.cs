using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitdeploytest.Startup))]
namespace gitdeploytest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
