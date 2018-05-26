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


            game.ShowScore().ShouldBeEqualTo("Love:Love");
        }

        [Test]
        public void Test_ServerEarnedPoint_Fifteen_Love()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();

            game.ShowScore().ShouldBeEqualTo("Fifteen:Love");
        }

        [Test]
        public void Test_ServerEarnedTwoPoints_Thirty_Love()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ServerEarnedPoint();

            game.ShowScore().ShouldBeEqualTo("Thirty:Love");
        }

        [Test]
        public void Test_ServerEarnedThreePoints_Forty_Love()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ServerEarnedPoint();
            game.ServerEarnedPoint();

            game.ShowScore().ShouldBeEqualTo("Forty:Love");
        }

        [Test]
        public void Test_ServerReceiver_Fifteen_Fifteen()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();

            game.ShowScore().ShouldBeEqualTo("Fifteen:Fifteen");
        }

        [Test]
        public void Test_Server_Win_Receiver_Fifteen()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ServerEarnedPoint();
            game.ServerEarnedPoint(); //Player Win if earned 4 points 

            game.ShowScore().ShouldBeEqualTo("Winner: Nick Kyrgios");
        }

        [Test]
        public void Test_Server_Thirty_Receiver_Win()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ReceiverEarnedPoint();

            game.ShowScore().ShouldBeEqualTo("Winner: Dominic Thiem");
        }

        [Test]
        public void Test_Server_Receiver_Deuce()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();

            game.ShowScore().ShouldBeEqualTo("Deuce");
        }

        [Test]
        public void Test_Server_Receiver_Advantage_In()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();

            game.ShowScore().ShouldBeEqualTo("Advantage in");
        }

        [Test]
        public void Test_Server_Win_After_Advantage_In()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint(); //Deuce
            game.ServerEarnedPoint(); //Adv in
            game.ServerEarnedPoint();

            game.ShowScore().ShouldBeEqualTo("Winner: Nick Kyrgios");
        }

        [Test]
        public void Test_Receiver_Advantage_Out()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint(); //Deuce
            game.ReceiverEarnedPoint(); //Adv out


            game.ShowScore().ShouldBeEqualTo("Advantage out");
        }

        [Test]
        public void Test_Receiver_Win_After_Advantage_Out()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint(); //Deuce
            game.ReceiverEarnedPoint(); //Adv out
            game.ReceiverEarnedPoint();

            game.ShowScore().ShouldBeEqualTo($"Winner: Dominic Thiem");
        }

        [Test]
        public void Test_Deuce_After_Advantange_In()
        {
            var game = new Game("Nick Kyrgios", "Dominic Thiem");

            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint();
            game.ServerEarnedPoint();
            game.ReceiverEarnedPoint(); //Deuce
            game.ServerEarnedPoint(); //Adv in
            game.ReceiverEarnedPoint(); //Deuce

            game.ShowScore().ShouldBeEqualTo($"Deuce");
        }

        
    }
}