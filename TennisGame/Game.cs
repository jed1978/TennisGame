namespace TennisGame
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
            if (Server.Point == Receiver.Point && Server.Point == 3)
            {
                return "Deuce";
            }

            if (Server.Point == 4 && Receiver.Point == 3)
            {
                return "Advantage in";
            }

            if (Server.Point == 3 && Receiver.Point == 4)
            {
                return "Advantage out";
            }

            return RegularScoreRule(Server.Point, Receiver.Point);
        }

        private string Winner(int serverPoint, int receiverPoint)
        {
            if (serverPoint == 5 && receiverPoint == 3)
            {
                return $"Winner: {Server.Name}";
            }

            if (serverPoint == 3 && receiverPoint == 5)
            {
                return $"Winner: {Receiver.Name}";
            }

            if (serverPoint == 4)
            {
                return $"Winner: {Server.Name}";
            }

            if (receiverPoint == 4)
            {
                return $"Winner: {Receiver.Name}";
            }

            return "";
        }

        private string RegularScoreRule(int serverPoint, int receiverPoint)
        {
            var winner = Winner(serverPoint, receiverPoint);
            return winner != "" ? winner : $"{DescribeScore(serverPoint)}:{DescribeScore(receiverPoint)}";
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