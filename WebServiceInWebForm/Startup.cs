using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebServiceInWebForm.Startup))]
namespace WebServiceInWebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
