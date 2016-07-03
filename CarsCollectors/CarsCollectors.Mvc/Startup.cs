using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsCollectors.Mvc.Startup))]
namespace CarsCollectors.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
