using CarsCollectors.Mvc.AutoMapper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CarsCollectors.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //WebApiConfig.Register(new System.Web.Http.HttpConfiguration());
            AutoMapperConfig.RegisterMappings();
        }
    }
}
