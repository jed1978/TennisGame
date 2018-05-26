using System.Collections;

namespace TennisGame
{
    public class Game
    {
        private Hashtable _scoreMap;
        public Player Server { get; }
        public Player Receiver { get; }


        public Game(Player server, Player receiver)
        {
            Server = server;
            Receiver = receiver;
            _scoreMap = new Hashtable
            {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };
        }


        public string Score()
        {
            if (Server.Point == 4)
                return "Win:Loss";
                
            return $"{ConvertToScore(Server.Point)}:{ConvertToScore(Receiver.Point)}";
        }

        private string ConvertToScore(int playerPoint)
        {
            return _scoreMap[playerPoint].ToString();
        }
    }
}