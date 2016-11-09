using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Everything.Startup))]
namespace Everything
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
