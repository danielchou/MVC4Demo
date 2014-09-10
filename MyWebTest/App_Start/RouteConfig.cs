using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace MyWebTest {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Pitfall", //有瑕疵的Routing，要測試時才打開!    
            //    url: "{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
               name: "SpecialRouting",
               url: "{contry}-{lang}/public/blog/{controller}-{action}/{postId}",
               defaults: new { controller = "Route", action = "Mvc", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Demo", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}