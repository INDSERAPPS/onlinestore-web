using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlinestore_web.Startup))]
namespace onlinestore_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
