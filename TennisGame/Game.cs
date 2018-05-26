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
                serverPoint = 15;

            return $"{serverPoint}:0";
        }

        public string Score()
        {
            var serverScore = "Love";
            if (Server.Point == 1)
            {
                serverScore = "Fifteen";
            }

            return $"{serverScore}:Love";
        }
    }
}