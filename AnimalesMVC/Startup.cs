using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnimalesMVC.Startup))]
namespace AnimalesMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
