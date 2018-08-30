using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_App_v1
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IBusiness, BusinessClass>();
        }
    }
}