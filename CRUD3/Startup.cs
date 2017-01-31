using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUD3.Startup))]
namespace CRUD3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
