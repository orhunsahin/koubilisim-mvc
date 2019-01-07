using KouStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KouStore.Controllers
{
    public class HomeController : Controller
    {
        KouStoreEntities db = new KouStoreEntities();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MenProduct = db.Products.Where(x => x.Category.Name.Equals("Erkek")).ToList();
            ViewBag.WomenProduct = db.Products.Where(x => x.Category.Name.Equals("Kadın")).ToList();
            ViewBag.SportsProduct = db.Products.Where(x => x.Category.Name.Equals("Spor")).ToList();
            ViewBag.ElectronicsProduct = db.Products.Where(x => x.Category.Name.Equals("Elektronik")).ToList();
            ViewBag.Slider = db.genMainSliders.ToList();
            ViewBag.PromoRight = db.genPromoRights.ToList();

            this.GetDefaultData();

            return View();
        }      

    }
}