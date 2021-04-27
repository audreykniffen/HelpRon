﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelpRon.Controllers
{
    public class HelloWorldController : Controller
    {
      

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
