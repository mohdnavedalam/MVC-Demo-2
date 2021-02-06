using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Demo_2.Startup))]
namespace MVC_Demo_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
