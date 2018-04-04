using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBookDB.Startup))]
namespace WebBookDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
