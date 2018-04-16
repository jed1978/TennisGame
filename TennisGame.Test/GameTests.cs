using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using NUnit.Framework;

namespace TennisGame.Test
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void TestNewGame()
        {
            var target = new Game("Rafael Nadal", "Roger Federer");

            var expected = "0:0";

            target.Score().ShouldBeEqualTo(expected);
        }
    }
}
