using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapMvcAttributeRoutes();












            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "Movies/Released/{Year}/{Month}",
            //    new { Controller = "Movies", action = "ByReleaseDate" },

            //     //new { Year = @"\d{4}", Month = @"\d{2}" });

            //     new { Year = @"2015|2016", Month = @"\d{2}" });












            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Random", id = UrlParameter.Optional }
            );
        }
    }
}
