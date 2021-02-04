using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class TempStorage
    {
        private static List<NewMovie> movies = new List<NewMovie>();

        public static IEnumerable<NewMovie> Movies => movies;

        public static void AddMovie(NewMovie movie)
        {
            movies.Add(movie);
        }
    }
}
