using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FesLibrary.Startup))]
namespace FesLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
