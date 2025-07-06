using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChemApp.Startup))]
namespace ChemApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
