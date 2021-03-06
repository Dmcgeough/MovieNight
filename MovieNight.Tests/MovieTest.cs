﻿using System;
using System.Collections.Generic;
using MovieNight.Library.Models;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTest
    {
        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1;
            var sut = new Movie();
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}