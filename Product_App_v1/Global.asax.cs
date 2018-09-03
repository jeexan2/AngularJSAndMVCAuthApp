using Business;
using Product_App_v1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Product_App_v1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //UnityConfig.RegisterComponents();

            Bootstrapper.Init();
           // GlobalConfiguration.Configuration.DependencyResolver =
           // Bootstrapper.Init();
           //  HomeController initiator = DependencyInjector.Retrieve<HomeController>(new BusinessClass());
           // IBusiness business = DependencyInjector.Retrieve<IBusiness>();

        }
    }
}
