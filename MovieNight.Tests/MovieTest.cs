using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTest
    {
        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Enum);
            var sut = new Movie();
            var actual = sut.Actors;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1;
            var sut = new Movie();
            var actual = sut.Actors;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
