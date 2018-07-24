using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {           
        public ActionResult Search(string name = "French")
        {
            //throw new Exception("Something terrible has happened");

            // If user sneaks a script, this will render the text and stop a cross site scripting attack
            var message = Server.HtmlEncode(name);

            return Content(message);
        }

    }
}
