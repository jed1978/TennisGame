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

        [Test]
        public void Test_ServerReceiver_0_0()
        {
            var serverName = "Nick Kyrgios";
            var receiverName = "Dominic Thiem";

            var game = new Game(serverName, receiverName);

            game.ShowPoints().ShouldBeEqualTo("0:0");

        }
    }
}