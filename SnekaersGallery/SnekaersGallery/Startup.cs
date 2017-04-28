using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SnekaersGallery.Startup))]
namespace SnekaersGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
