using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment3.Models;
using Assignment3.Models.ViewModels;


namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {


        //for the movie context
        private MovieListContext context { get; set; }

        //constructor for mocie context
        public HomeController(MovieListContext con)
        {
            context = con;
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
            if (ModelState.IsValid)
            {
                context.Movies.Add(movie);
                context.SaveChanges();
            }
            return View("Confirmation", movie);
        }

        //for listing/viewing all the movies
        [HttpGet]
        public IActionResult ListMovies()
        {
            return View(new RatingsViewModel
            {
                G = context.Movies.Where(x => x.Rating == "G"),
                PG = context.Movies.Where(x => x.Rating == "PG"),
                PG13 = context.Movies.Where(x => x.Rating == "PG-13"),
                R = context.Movies.Where(x => x.Rating == "R")
            });
        }

        //for editing movie
        [HttpPost]
        public IActionResult ListMovie(NewMovie movie)
        {
            return View("EditMovie", movie);
        }

        [HttpGet]
        public IActionResult EditMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditMovie(NewMovie movie)
        {
            if (ModelState.IsValid)
            {
                context.Update(context.Movies.Where(x=> x.MovieId == movie.MovieId));
                //context.Update<NewMovie>(movie);
                context.SaveChanges();

            }
            return View("Confirmation", movie);
        }
        //delete movie
        [HttpGet]
        public IActionResult DeleteMovie(NewMovie movie)
        {
            context.Remove(context.Movies.Where(x => x.MovieId == movie.MovieId));
            context.SaveChanges();
            return View("ListMovies", movie);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}