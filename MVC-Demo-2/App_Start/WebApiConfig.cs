using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVC_Demo_2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Attribute Routing
            config.MapHttpAttributeRoutes();

            // Convention based Routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
