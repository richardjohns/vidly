using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // method enables attribute routing rather than convention-based routing

            //Convention-based routing
            routes.MapRoute(
                "MoviesByReleaseDate", // name of route
                "movies/released/{year}/{month}", // url pattern
                new {controller = "Movies", action = "ByReleaseDate"}, // anonymous object used for default
                new { year = @"\d{4}", month = @"\d{2}" } // anon object for setting constraints on url params
            );

            routes.MapRoute(
                "Customers",
                "customers/details/{id}",
                new { controller = "Customers", action = "ShowCustomer" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
