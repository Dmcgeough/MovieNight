using System;
using System.Collections.Generic;
using MovieNight.Library.Abstracts;
using MovieNight.Library.Enums;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public List<Actor> Actors
        {
            get;
            set;
        }

        public EGenre Genre
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public Movie()
        {
            Actors = new List<Actor>()
      {
        new Actor()
      };
        Title = "(no title)";
        Genre = EGenre.Romantic_Western;
        }
    }
}
