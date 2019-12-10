using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFormsAuthentication.Startup))]
namespace MVCFormsAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
