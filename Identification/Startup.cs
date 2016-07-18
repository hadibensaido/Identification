using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identification.Startup))]
namespace Identification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
