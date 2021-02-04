using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //for the home page view (contains the picture of joel)
        public IActionResult Index()
        {
            return View();
        }

        //for the podcast page view (contains link to baconsale
        public IActionResult Podcasts()
        {
            return View();
        }

        //for loading the page
        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        //for the movies form 
        [HttpPost]
        public IActionResult Movies(NewMovie movie)
        {
            TempStorage.AddMovie(movie);
            return View("Confirmation", movie);
        }

        //for listing/viewing all the movies

        public IActionResult ListMovies()
        {
            return View(TempStorage.Movies);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
