using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_App_v1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductService productService;
        public ProductController()
        {
            this.productService = new ProductService();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            productService.Insert(ProductModelBuilder.productModeltoProduct(product));
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {
            productService.Update(ProductModelBuilder.productModeltoProduct(product));
            return View();
        }
        public JsonResult GetProductList()
        {
            return Json(productService.GetProductList());
        }
    }
}