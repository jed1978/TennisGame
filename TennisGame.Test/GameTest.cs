﻿using FluentAssert;
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
}