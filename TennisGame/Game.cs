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
            return RegularScoreRule(Server.Point, Receiver.Point);
        }

        private string RegularScoreRule(int serverPoint, int receiverPoint)
        {
            var serverScore = "Love";
            var receiverScore = "Love";

            if (serverPoint == 1)
            {
                serverScore = "Fifteen";
            }
            else if (serverPoint == 2)
            {
                serverScore = "Thirty";
            }
            else if (serverPoint == 3)
            {
                serverScore = "Forty";
            }

            return $"{serverScore}:{receiverScore}";
        }
    }
}