using System.Web.Mvc;
using System.Web.Routing;
namespace A3SSP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "",
                url: "CompanyType",
                defaults: new { controller = "Company", action = "CompanyType" }
            );
            routes.MapRoute(
                name: "",
                url: "CompanyTypeEdit/{Id}",
                defaults: new { controller = "Company", action = "CompanyTypeEdit" }
            );
            routes.MapRoute(
                name: "",
                url: "CompanyTypeDelete/{Id}",
                defaults: new { controller = "Company", action = "CompanyTypeDelete" }
            );
            routes.MapRoute(
                name: "",
                url: "Company",
                defaults: new { controller = "Company", action = "Company" }
            );
            routes.MapRoute(
                name: "",
                url: "Index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Index",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "Else",
                url: "{*url}",
                defaults: new { controller = "Home", action = "Error404" }
            );
        }
    }
}
