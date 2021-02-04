using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class NewMovie
    {
        [Required(ErrorMessage = "Please select the movie category.")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter the movie title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the movie year(s).")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Please enter the movie director.")]
        public string Director { get; set; }
        [Required(ErrorMessage ="Please select the movie rating.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [StringLength(25,ErrorMessage ="Notes can only be 25 characters long.") ]
        public string Notes { get; set; }

    }
}
