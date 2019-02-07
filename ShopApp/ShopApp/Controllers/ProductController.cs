using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.Controllers
{
    public class ProductController : Controller
    {
        ShopStore storeDB = new ShopStore();
        // GET: Product
        public ActionResult Productcontroller()
        {
            var produits = storeDB.Products.ToList();
            return PartialView(produits);
        }
    }
}