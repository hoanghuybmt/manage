using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Management_System.Startup))]
namespace Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
