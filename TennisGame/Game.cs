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

        public string ShowPoints()
        {
            var serverPoint = 0;
            if (Server.Point == 1)
            {
                serverPoint = 15;
            }
            else if (Server.Point == 2)
            {
                serverPoint = 30;
            }
            else if (Server.Point == 3)
            {
                serverPoint = 40;
            }

            return $"{serverPoint}:0";
        }

        public string ShowScore()
        {
            var serverScore = "Love";
            if (Server.Point == 1)
            {
                serverScore = "Fifteen";
            }
            else if (Server.Point == 2)
            {
                serverScore = "Thirty";
            }
            else if (Server.Point == 3)
            {
                serverScore = "Forty";
            }

            return $"{serverScore}:Love";
        }
    }
}