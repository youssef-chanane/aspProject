using Examen_ASP.Net.Data;
using Examen_ASP.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen_ASP.Net.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        private Examen_ASPNetContext db = new Examen_ASPNetContext();

        public ActionResult Index(string search)
        {
            ViewModel model = new ViewModel();
            model.BestOffers = db.Products.OrderByDescending(product => product.Price-product.Discount).Take(3);
            if (!String.IsNullOrEmpty(search))
            {
                model.Products = db.Products.Where(s => s.Title.Contains(search));
            }
            else
            {
                model.Products = db.Products.ToList();
            }
            model.Categories = db.Categories.ToList();
            

            return View(model);
        }
        public ActionResult CategorieProducts(int? id)
        {
            ViewModel model = new ViewModel();
            model.Products = db.Products.Where(product=>product.Category_id==id).ToList();
            model.Categories = db.Categories.ToList();
            Category category = db.Categories.Find(id);
            ViewBag.category = category.Name;
            //model.Products = db.Products.ToList();


            return View(model);
        }

    }
}