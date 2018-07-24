using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        public ActionResult Search(string name = "French")
        {
            // If user sneaks a script, this will render the text and stop a cross site scripting attack
            var message = Server.HtmlEncode(name);

            //return RedirectToAction("Index", "Home", new { name = name });
            return RedirectToRoute("Default", new {controller = "Home", action = "About"});
            //return File(Server.MapPath("~/Content/site.cs"), "text/css");
            //return Json(new { Message = message, Name = "Hamza" }, JsonRequestBehavior.AllowGet);

        }

    }
}
