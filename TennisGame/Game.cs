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
            //return DeuceScoreRule(Server.Point, Receiver.Point);

            return RegularScoreRule(Server.Point, Receiver.Point);
        }

        private string DeuceScoreRule(int serverPoint, int receiverPoint)
        {
            if (serverPoint == receiverPoint && serverPoint == 3)
            {
                return "Deuce";
            }

            if (serverPoint == 4 && receiverPoint == 3)
            {
                return "Advantage in";
            }

            if (serverPoint == 3 && receiverPoint == 4)
            {
                return "Advantage out";
            }

            return "";
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
            if (DeuceScoreRule(Server.Point, Receiver.Point) == "")
            {
                if (Winner(serverPoint, receiverPoint) == "")
                {
                    return $"{DescribeScore(serverPoint)}:{DescribeScore(receiverPoint)}";
                }
                return Winner(serverPoint, receiverPoint);
            }
            return DeuceScoreRule(Server.Point, Receiver.Point);
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