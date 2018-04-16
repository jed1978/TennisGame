namespace TennisGame
{
    public class Game
    {
        private int _homeGamePoints;
        private int _awayGamePoints;

        public Game(string homePlayer, string awayPlayer)
        {
        }

        public string Score()
        {
            return $"{_homeGamePoints}:{_awayGamePoints}";
        }

        public void EarnedPoint(string side)
        {
            if (side == "Home")
            {
                _homeGamePoints++;
            }
            else
            {
                _awayGamePoints++;
            }
        }
    }
}