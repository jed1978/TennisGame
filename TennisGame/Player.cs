namespace TennisGame
{
    public class Player
    {
        public int Point { get; private set; }
        public string Name { get; }

        public Player(string name)
        {
            Name = name;
            Point = 0;
        }

        public void EarnedPoint()
        {
            Point++;
        }
    }
    
}