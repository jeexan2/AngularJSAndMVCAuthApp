using Business;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Microsoft.Practices.Unity;

namespace Product_App_v1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductService, ProductService>();
          
          //  DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            //DependencyResolver.SetResolver(container);
        }
    }
}