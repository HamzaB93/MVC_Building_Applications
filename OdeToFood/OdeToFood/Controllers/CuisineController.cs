using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // Http get selector, this action will repsond when there is a get request
        [HttpGet]
        public ActionResult Search(string name = "French")
        {
            // If user sneaks a script, this will render the text and stop a cross site scripting attack
            var message = Server.HtmlEncode(name);

            return Content(message);
        }

    }
}
