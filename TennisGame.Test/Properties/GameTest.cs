using FluentAssert;
using NUnit.Framework;

namespace TennisGame.Test.Properties
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void Test_TwoPlayerJoinGame()
        {
            var game = CreateNewGame();
            game.Server.ShouldNotBeNull();
            game.Receiver.ShouldNotBeNull();
        }

        [Test]
        public void Test_LoveLove()
        {
            var game = CreateNewGame();
            game.Score().ShouldBeEqualTo("Love:Love");
        }

        [Test]
        public void Test_ServerEarnedOnePoint_Fifteen_Love()
        {
            var game = CreateNewGame();
            game.Server.EarnedPoint();
            game.Score().ShouldBeEqualTo("Fifteen:Love");
        }

        [Test]
        public void Test_ServerEarnedTwoPoint_Thirty_Love()
        {
            var game = CreateNewGame();
            game.Server.EarnedPoint();
            game.Server.EarnedPoint();
            game.Score().ShouldBeEqualTo("Thirty:Love");
        }

        [Test]
        public void Test_ServerEarnedThreePoint_Forty_Love()
        {
            var game = CreateNewGame();
            game.Server.EarnedPoint();
            game.Server.EarnedPoint();
            game.Server.EarnedPoint();
            game.Score().ShouldBeEqualTo("Forty:Love");
        }

        [Test]
        public void Test_ServerEarnedFourPoint_Win()
        {
            var game = CreateNewGame();
            game.Server.EarnedPoint();
            game.Server.EarnedPoint();
            game.Server.EarnedPoint();
            game.Server.EarnedPoint();
            game.Score().ShouldBeEqualTo("Win:Loss");
        }

        [Test]
        public void Test_ReceiverEarnedFourPoint_Win()
        {
            var game = CreateNewGame();
            game.Receiver.EarnedPoint();
            game.Receiver.EarnedPoint();
            game.Receiver.EarnedPoint();
            game.Receiver.EarnedPoint();
            game.Score().ShouldBeEqualTo("Loss:Win");
        }

        private Game CreateNewGame()
        {
            var server = new Player();
            var receiver = new Player();
            var game = new Game(server, receiver);
            return game;
        }
    }
}