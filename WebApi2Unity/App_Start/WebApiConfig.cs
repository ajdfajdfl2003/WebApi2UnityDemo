using Microsoft.Practices.Unity;
using System.Web.Http;
using WebApi2Unity.Interfaces;
using WebApi2Unity.Resolver;
using WebApi2Unity.Utility;

namespace WebApi2Unity
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 設定和服務
            var container = new UnityContainer();
            container.RegisterType<IProductRepo, ProductRepo>("AProducts", new ContainerControlledLifetimeManager(),
                new InjectionConstructor("ProductDb01"));
            config.DependencyResolver = new UnityResolver(container);

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
            );
        }
    }
}