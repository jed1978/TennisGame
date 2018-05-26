namespace TennisGame
{
    public class Game
    {
        private readonly DeuceScoreRule _deuceRule;
        private readonly RegularScoreRule _reqularScoreRule;
        private readonly WinnerRule _winnerRule;
        private int _serverPoint;
        private int _receiverPoint;

        public Player Server { get; }
        public Player Receiver { get; }

        public Game(string serverName, string receiverName)
        {
            Server = new Player(serverName);
            Receiver = new Player(receiverName);
            _deuceRule = new DeuceScoreRule();
            _reqularScoreRule = new RegularScoreRule();
            _winnerRule = new WinnerRule(serverName, receiverName);
        }

        public string ShowScore()
        {
            if (_deuceRule.Match(_serverPoint, _receiverPoint))
            {
                return _deuceRule.Score;
            }

            if (_reqularScoreRule.Match(_serverPoint, _receiverPoint))
            {
                return _reqularScoreRule.Score;
            }

            return _winnerRule.Match(_serverPoint, _receiverPoint) ? _winnerRule.Score : "";
        }

        public void ServerEarnedPoint()
        {
            _serverPoint++;
        }

        public void ReceiverEarnedPoint()
        {
            _receiverPoint++;
        }
    }
}