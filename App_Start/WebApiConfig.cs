using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            // My Url
            config.Routes.MapHttpRoute(
                name: "DefaultApi",   // unique 
                routeTemplate: "api/{controller}/{id}", // After localhost 
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
