using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelpRon.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /Hello/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
