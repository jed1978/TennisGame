namespace TennisGame
{
    public class RegularScoreRule
    {
        public RegularScoreRule()
        {
        }

        public string Match(int serverPoint, int receiverPoint)
        {
            return $"{DescribeScore(serverPoint)}:{DescribeScore(receiverPoint)}";

        }

        private string DescribeScore(int point)
        {
            string score = "Love";
            if (point == 1)
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

            return score;
        }
    }
}