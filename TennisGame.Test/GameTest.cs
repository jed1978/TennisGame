using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame.Test
{
    [TestClass]
    public class GameTest
    {
        private Game target;

        [TestInitialize]
        public void Init()
        {
            target = new Game("PlayerOne", "PlayerTwo");
        }

        [TestMethod]
        public void TestOpenGame()
        {
            Assert.AreEqual("Love All", target.Score());
        }

        [TestMethod]
        public void TestFifteenLove()
        {
            target.PlayerOneWinPoint();
            Assert.AreEqual("Fifteen Love", target.Score());
        }

        [TestMethod]
        public void TestFifteenPoint()
        {
            target.PlayerOneWinPoint();
            Assert.AreEqual("15:0", target.Point());
        }
    }
}
