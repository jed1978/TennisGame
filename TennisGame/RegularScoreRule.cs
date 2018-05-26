namespace TennisGame
{
    public class RegularScoreRule : IScoreRule
    {
        public RegularScoreRule()
        {
        }

        public string Score { get; private set; }

        public bool Match(int serverPoint, int receiverPoint)
        {
            var serverScore = DescribeScore(serverPoint);
            var describeScore = DescribeScore(receiverPoint);

            if (serverScore == "" || describeScore == "")
                return false;
            Score = $"{serverScore}:{describeScore}";
            return true;
        }

        private string DescribeScore(int point)
        {            
            if (point == 0)
            {
                return "Love";
            }
            else if (point == 1)
            {
                return "Fifteen";
            }
            else if (point == 2)
            {
                return "Thirty";
            }
            else if (point == 3)
            {
                return "Forty";
            }
            
            return "";
        }
    }
}