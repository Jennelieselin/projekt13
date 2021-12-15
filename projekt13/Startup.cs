using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projekt13.Startup))]
namespace projekt13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
