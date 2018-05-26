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
            return "0:0";
        }

        public string Score()
        {
            return "Love:Love";
        }
    }
}