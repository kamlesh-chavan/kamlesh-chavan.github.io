using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartMakaan.Startup))]
namespace SmartMakaan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
