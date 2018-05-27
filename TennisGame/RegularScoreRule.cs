namespace TennisGame
{
    public class RegularScoreRule : IScoreRule
    {        
        public string Score { get; private set; }

        public bool Match(int serverPoint, int receiverPoint)
        {
            var serverScore = DescribeScore(serverPoint);
            var describeScore = DescribeScore(receiverPoint);
            Score = $"{serverScore}:{describeScore}";

            return serverScore != "" && describeScore != "";
        }

        private string DescribeScore(int point)
        {
            if (point == 0)
                return "Love";

            if (point == 1)
                return "Fifteen";

            if (point == 2)
                return "Thirty";

            return point == 3 ? "Forty" : "";
        }
    }
}