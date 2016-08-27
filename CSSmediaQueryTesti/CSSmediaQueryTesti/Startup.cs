using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSSmediaQueryTesti.Startup))]
namespace CSSmediaQueryTesti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
