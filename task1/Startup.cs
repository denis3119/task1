using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(task1.Startup))]
namespace task1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
