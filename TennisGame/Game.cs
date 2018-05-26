﻿namespace TennisGame
{
    public class Game
    {
        public Player Server { get; }
        public Player Receiver { get; }

        public Game(string serverName, string receiverName)
        {
            Server = new Player(serverName);
            Receiver = new Player(receiverName);
        }

        public string ShowScore()
        {
            return RegularScoreRule(Server.Point, Receiver.Point);
        }

        private string RegularScoreRule(int serverPoint, int receiverPoint)
        {
            return $"{DescribeScore(serverPoint)}:{DescribeScore(receiverPoint)}";
        }

        private string DescribeScore(int point)
        {
            string score = "Love";
            if (point == 1)
            {
                return "Fifteen";
            }
            else if (point == 2)
            {
                return "Thirty";
            }
            else if (point == 3)
            {
                return "Forty";
            }

            return score;
        }
    }
}