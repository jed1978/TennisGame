namespace TennisGame
{
    public class Game
    {
        private readonly DeuceScoreRule deuceRule;
        private readonly RegularScoreRule reqularScoreRule;
        public Player Server { get; }
        public Player Receiver { get; }

        public Game(string serverName, string receiverName)
        {
            Server = new Player(serverName);
            Receiver = new Player(receiverName);
            deuceRule = new DeuceScoreRule();
            reqularScoreRule = new RegularScoreRule();
        }

        public string ShowScore()
        {
            var deuce = deuceRule.Match(Server.Point, Receiver.Point);

            if (deuce == "")
            {
                var winner = Winner(Server.Point, Receiver.Point);
                if (winner == "")
                {
                    return reqularScoreRule.Match(Server.Point, Receiver.Point);
                }
                return winner;
            }
            return deuce;
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
    }
}