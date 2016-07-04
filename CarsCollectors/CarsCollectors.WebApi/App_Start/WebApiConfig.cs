using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using CarsCollectors.IoC;

namespace CarsCollectors.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, Container container)
        {
            var webapiContainer = new Container();

            webapiContainer.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            BootStrapper.RegisterServices(webapiContainer, container.Options.DefaultScopedLifestyle);
            webapiContainer.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(webapiContainer);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
