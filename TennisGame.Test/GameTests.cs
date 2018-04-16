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
        private Game _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Game("Rafael Nadal", "Roger Federer");
        }

        [Test]
        public void TestNewGame()
        {
            var expected = "0:0";

            _target.Score().ShouldBeEqualTo(expected);
        }

        [Test]
        public void TestHomePlayerScoreFifteen()
        {
            var expected = "1:0";
            _target.EarnedPoint("Home");

            _target.Score().ShouldBeEqualTo(expected);
        }

        [Test]
        public void TestHomePlayerScoreThirty()
        {
            var expected = "2:0";
            _target.EarnedPoint("Home");
            _target.EarnedPoint("Home");

            _target.Score().ShouldBeEqualTo(expected);
        }
    }
}
