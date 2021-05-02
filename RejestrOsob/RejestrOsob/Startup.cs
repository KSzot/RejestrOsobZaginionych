using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RejestrOsob.Startup))]
namespace RejestrOsob
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
