using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maize_Trade.Startup))]
namespace Maize_Trade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
