using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_App_v1
{
    public  static class ProductModelBuilder
    {
        public static Product productModeltoProduct(ProductModel model)
        {
            Product product = new Product();
            Random random = new Random();
            product.Id = random.Next();
            product.Name = model.Name;
            product.Code = model.Code;
            product.Stock = model.Stock;
            product.Created_At = DateTime.Now;
            return product;
        }
    }
}