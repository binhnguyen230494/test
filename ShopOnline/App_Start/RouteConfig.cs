﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Product Category",
                url: "san-pham/{metatitle}-{cateid}",
                defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional }, namespaces: new[] { "ShopOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Product Detail",
                url: "chi-tiet/{metatitle}-{id}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional }, namespaces: new[] { "ShopOnline.Controllers" }
            );
            routes.MapRoute(
                name: "About",
                url: "gioi-thieu",
                defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "ShopOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Cart",
                url: "gio-hang",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "ShopOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Payment",
                url: "thanh-toan",
                defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional }, namespaces: new[] { "ShopOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Add cart",
                url: "them-gio-hang",
                defaults: new { controller = "Cart", action = "Additem", id = UrlParameter.Optional }, namespaces: new[] { "ShopOnline.Controllers" }
            );
            routes.MapRoute(
                name: "payment success ",
                url: "hoan-thanh",
                defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional }, namespaces: new[] { "ShopOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "ShopOnline.Controllers" }
            );
            
        }
    }
}
