using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index()
        {
            // Entity framework will go into sql server and retrieve all the restaurants and put it into list
            var model = _db.Restaurants.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            // Add information to the view bag so that the view can use it
            //ViewBag.Message = "Your app description page.";

            // Creating model object and send the properties to the View
            var model = new AboutModel();
            model.Name = "Hamza";
            model.Location = "London, UK";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Disposable resource
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
