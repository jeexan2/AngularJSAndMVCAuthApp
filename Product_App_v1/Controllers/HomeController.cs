using Business;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Product_App_v1.Controllers
{
    public class HomeController : Controller
    {
        // private IProductRepository productRepository;
        private ProductService productService;
        public HomeController(){
            productService = new ProductService();
        }
        public ActionResult Index()
        {
            ProductListModel model = new ProductListModel();
             model.Products = productService.GetProductList().ToList();
            return View(model);
        }

        
         [Route("Home/ProductList")]
        public JsonResult ProductList()
        {
            ProductListModel model = new ProductListModel();
            model.Products = productService.GetProductList().ToList();
            return Json(model,JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}