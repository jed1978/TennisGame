namespace TennisGame
{
    public class Player
    {
        public int Point { get; private set; }

        public void EarnedPoint()
        {
            Point++;
        }
    }
}