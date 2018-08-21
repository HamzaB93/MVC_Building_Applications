using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        //
        // GET: /Reviews/

        // Not the id for the review, its the id of the restaurant
        // Bind will find the restuarantId with the name of id 
        public ActionResult Index([Bind(Prefix="id")] int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);

            if (restaurant != null)
            {
                return View(restaurant);
            }

            return HttpNotFound(); 
        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            //Model binder will instantiate RestaurantReview and populate it with values from the request
            //Will also give the restaurant id to associate it correctly.

            // check if model state is valid
            if (ModelState.IsValid)
            {
                // Add the review to the collection
                _db.Reviews.Add(review);

                // Save to the db
                _db.SaveChanges();

                return RedirectToAction("Index", new { id = review.RestaurantId });
            }

            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }


    }
}
