using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace A3SSP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Application_BeginRequest()
        {
            
            //HttpContext.Current.Response.Write("1-Controller : " + routeData.Values["controller"] + "<br />");
            //HttpContext.Current.Response.Write("1-Action : " + routeData.Values["action"] + "<br />");

            HttpContextBase currentContext = new HttpContextWrapper(HttpContext.Current);
            UrlHelper urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            RouteData routeData = urlHelper.RouteCollection.GetRouteData(currentContext);
            HttpContext.Current.Response.Write("2-Controller : " + routeData.Values["controller"] + "<br />");
            HttpContext.Current.Response.Write("2-Action : " + routeData.Values["action"] + "<br />");
        }
    }
}
