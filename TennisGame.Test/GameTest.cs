using FluentAssert;
using NUnit.Framework;

namespace TennisGame.Test
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void Test_TwoPlayerJoinTheGame()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");
            game.Server.ShouldNotBeNull();
            game.Receiver.ShouldNotBeNull();

        }
    }

    public class Game
    {
        public Game(string server, string receiver)
        {
            throw new System.NotImplementedException();
        }

        public Player Server { get; private set; }
        public Player Receiver { get; private set; }

        public class Player
        {
        }
    }
}