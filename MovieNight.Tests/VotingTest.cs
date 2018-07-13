
using System;
using MovieNight.Library.Models;
using Xunit;

namespace MovieNight.Test
{
    public class VotingTest
    {
        [Fact]
        public void Test_VotingId()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
