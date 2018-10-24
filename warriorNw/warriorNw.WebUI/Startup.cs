using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(warriorNw.WebUI.Startup))]
namespace warriorNw.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
