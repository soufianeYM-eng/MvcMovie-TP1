using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MvcMovie.Controllers
{
    public class HomeWorldController : Controller
    {
        // GET: /HomeWorld/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        //
        // GET: /HomeWorld/Welcome/
        /*public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/

        // GET: /HomeWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        /*public string Welcome(string name="Soufiane", int level = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", Level is: " + level);
        }*/

    }
}
