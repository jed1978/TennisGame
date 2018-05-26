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
            var serverName = "Nick Kyrgios";
            var receiverName = "Dominic Thiem";

            var game = new Game(serverName, receiverName);

            game.Server.Name.ShouldBeEqualTo(serverName);
            game.Receiver.Name.ShouldBeEqualTo(receiverName);
        }
    }
}