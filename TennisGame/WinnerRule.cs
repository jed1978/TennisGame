namespace TennisGame
{
    public class WinnerRule : IScoreRule
    {
        private readonly string _serverName;
        private readonly string _receiverName;

        public string Score { get; private set; }

        public WinnerRule(string serverName, string receiverName)
        {
            _serverName = serverName;
            _receiverName = receiverName;
        }

        public bool Match(int serverPoint, int receiverPoint)
        {
            if (serverPoint == 5 && receiverPoint == 3 || serverPoint == 4)
            {
                Score = $"Winner: {_serverName}";
                return true;
            }

            if (serverPoint == 3 && receiverPoint == 5 || receiverPoint == 4)
            {
                Score = $"Winner: {_receiverName}";
                return true;
            }
            return false;
        }
    }
}