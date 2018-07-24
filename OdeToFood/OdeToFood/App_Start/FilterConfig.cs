using System.Web;
using System.Web.Mvc;

namespace OdeToFood
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Displays friendly error message, used across the application
            filters.Add(new HandleErrorAttribute());
        }
    }
}