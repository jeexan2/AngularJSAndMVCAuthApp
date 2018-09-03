using Business;
using Data;
using Data.DBModels;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Unity;

namespace Product_App_v1
{
    public static class Bootstrapper
    {

        public static void Init()
        {
            //var container = BuildUnityContainer();
            //IUnityContainer container = new UnityContainer();
            //DependencyInjector.Register<IBusiness, BusinessClass>();
           // DependencyInjector.Register<DbContext, ProductService>();
            //DependencyInjector.Register<Product, ProductService>();
            DependencyInjector.Register<IProductRepository, ProductRepository>();
           // return container;
        }
    }
}