﻿using OdeToFood.Models;
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

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
