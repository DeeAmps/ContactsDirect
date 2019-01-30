using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsDirect.Web.Startup))]
namespace ContactsDirect.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
