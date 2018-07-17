using System.Web.Mvc;
using System.Web.Routing;

namespace MedioClinic
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // MVC routes
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // DI
            AutofacConfig.ConfigureContainer();
        }
    }
}
