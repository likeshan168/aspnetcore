using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.Models;

namespace mvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(bool approved = false)
        {
            return View(new WebSiteContext()
            {
                Approved = approved,
                CopyrightYear = 1234,
                Version = new Version(1, 3, 3, 7),
                TagsToShow = 12
            });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
