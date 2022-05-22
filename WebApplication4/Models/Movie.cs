using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Movie
    {
        public Movie()
        {
            List<Person> people = new List<Person>();
            List<Genre> genres = new List<Genre>();
        }
        [Key]
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Display(Name = "Movie Cover")]
        public string ImageURL { get; set; }

   
    }
}
