using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //HttpContextBase currentContext = new HttpContextWrapper(HttpContext.Current);
            //UrlHelper urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            //RouteData routeData = urlHelper.RouteCollection.GetRouteData(currentContext);
            //string action = routeData.Values["action"] as string;
            //string controller = routeData.Values["controller"] as string;
            //Response.Write(controller+"<br />");
            //Response.Write(action + "<br />");

            foreach (Route r in RouteTable.Routes)
            {
                
                if (r.Defaults != null && r.Defaults["controller"] != null)
                    Response.Write(r.Defaults["controller"] + "<br />");
                else
                    Response.Write("NULL<br />");
            }
            return View();
        }
        public ActionResult Error404() {
            return View("Error404");
        }
    }
}