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

        [Test]
        public void Test_ServerEarnedPoint_Fifteen_Love()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.Server.EarnedPoint();
            game.ShowPoints().ShouldBeEqualTo("15:0");
            game.Score().ShouldBeEqualTo("Fifteen:Love");
        }

        [Test]
        public void Test_ServerEarnedTwoPoints_Thirty_Love()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.Server.EarnedPoint();
            game.Server.EarnedPoint();

            game.ShowPoints().ShouldBeEqualTo("30:0");
            game.Score().ShouldBeEqualTo("Thirty:Love");
        }
    }
}