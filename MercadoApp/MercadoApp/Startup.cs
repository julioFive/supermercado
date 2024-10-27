using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MercadoApp.Startup))]
namespace MercadoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
