using System.Media;
using FluentAssert;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TennisGame.Test.Properties
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void Test_TwoPlayerJoinGame()
        {
            var server = new Player();
            var receiver = new Player();
            var game = new Game(server, receiver);

            game.Server.ShouldNotBeNull();
            game.Receiver.ShouldNotBeNull();
        }

        [Test]
        public void Test_LoveLove()
        {
            var server = new Player();
            var receiver = new Player();
            var game = new Game(server, receiver);

            game.Score().ShouldBeEqualTo("Love:Love");
        }

        [Test]
        public void Test_ServerEarnedOnePoint_Fifteen_Love()
        {
            var server = new Player();
            var receiver = new Player();
            var game = new Game(server, receiver);

            server.EarnedPoint();
            game.Score().ShouldBeEqualTo("Fifteen:Love");
        }
    }
}