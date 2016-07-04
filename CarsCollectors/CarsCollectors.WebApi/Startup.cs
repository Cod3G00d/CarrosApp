using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CarsCollectors.WebApi.Startup))]

namespace CarsCollectors.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
