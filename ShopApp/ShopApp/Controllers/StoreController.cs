using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopApp.Models;
using System.Data.Entity;


namespace ShopApp.Controllers
{
    public class StoreController : Controller
    {
        ShopStore storeDB=new ShopStore();
        // GET: Store
        public ActionResult Index()
        {
            var products = storeDB.Products.ToList();
           
            return View(products);
        }
        public ActionResult Browse(string product)//return as querystring
        {
            var productModel = storeDB.Products.Include(m=>m.Type)
                .Single(g => g.Name == product);
            return View(productModel);
        }
        public ActionResult Details(int id)//return in url url/5 for example
        {
            var type = storeDB.Types.Find(id);
            return View(type);
        }

    }
}