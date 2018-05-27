namespace TennisGame
{
    public class DeuceScoreRule : IScoreRule
    {
        public string Score { get; private set; }

        public DeuceScoreRule()
        {
            Score = "";
        }

        public bool Match(int serverPoint, int receiverPoint)
        {
            
            if (serverPoint == receiverPoint && serverPoint == 3)
            {
                Score = "Deuce";
                return true;
            }

            if (serverPoint == 4 && receiverPoint == 3)
            {
                Score = "Advantage in";
                return true;
            }

            if (serverPoint == 3 && receiverPoint == 4)
            {
                Score = "Advantage out";
                return true;
            }

            return false;
        }
    }
}