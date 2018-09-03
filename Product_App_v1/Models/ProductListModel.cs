using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_App_v1
{
    public class ProductListModel
    {
        public IList<Product> Products { get; set; }
        public ProductListModel()
        {
            Products = new List<Product>();
        }
    }
}