using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NW.Startup))]
namespace NW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
