namespace TennisGame
{
    public class Game
    {
        public Player Server { get; }
        public Player Receiver { get; }
        

        public Game(Player server, Player receiver)
        {
            Server = server;
            Receiver = receiver;
        }


        public string Score()
        {
            return $"{ConvertToScore(Server.Point)}:{ConvertToScore(Receiver.Point)}";
        }

        private string ConvertToScore(int playerPoint)
        {
            if (playerPoint == 1)
                return "Fifteen";
            else
                return "Love";
        }
    }
}