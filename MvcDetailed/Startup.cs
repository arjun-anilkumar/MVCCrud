using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDetailed.Startup))]
namespace MvcDetailed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
