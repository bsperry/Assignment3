using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models.ViewModels
{
    public class RatingsViewModel
    {
        public IEnumerable<NewMovie> G { get; set; }
        public IEnumerable<NewMovie> PG { get; set; }
        public IEnumerable<NewMovie> PG13 { get; set; }
        public IEnumerable<NewMovie> R { get; set; }

    }
}
