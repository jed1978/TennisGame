namespace TennisGame
{
    public class DeuceScoreRule
    {
        public string Result { get; private set; }

        public DeuceScoreRule()
        {
            Result = "";
        }

        public string Match(int serverPoint, int receiverPoint)
        {
            
            if (serverPoint == receiverPoint && serverPoint == 3)
            {
                Result = "Deuce";
            }

            if (serverPoint == 4 && receiverPoint == 3)
            {
                Result = "Advantage in";
            }

            if (serverPoint == 3 && receiverPoint == 4)
            {
                Result = "Advantage out";
            }

            return Result;
        }
    }
}