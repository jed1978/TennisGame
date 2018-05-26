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

            game.Server.Name.ShouldBeEqualTo("Nick Kyrgios");
            game.Receiver.Name.ShouldBeEqualTo("Dominic Thiem");
        }

        [Test]
        public void Test_ServerReceiver_Draw_Love()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ShowPoints().ShouldBeEqualTo("0:0");
            game.Score().ShouldBeEqualTo("Love:Love");
        }
    }
}