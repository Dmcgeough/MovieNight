using System;
using MovieNight.Library.Abstracts;

namespace MovieNight.Library.Models
{
    public class Person : APerson
    {
        public History History
        {
            get;
            set;
        }

        public Person()
        {
            History = new History();
        }
    }
}
