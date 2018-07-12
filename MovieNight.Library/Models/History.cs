using System;
using System.Collections.Generic;
using MovieNight.Library.Abstracts;

namespace MovieNight.Library.Models
{
    public class History : AModel
    {
        public List<Movie> Movies
        {
            get;
            set;
        }

        public History()
        {
            Movies = new List<Movie>()
      {
        new Movie()
      };
        }
    }
}