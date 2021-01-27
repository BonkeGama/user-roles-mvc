using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rolezz.Startup))]
namespace Rolezz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
