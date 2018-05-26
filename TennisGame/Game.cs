namespace TennisGame
{
    public class Game
    {
        private readonly DeuceScoreRule _deuceRule;
        private readonly RegularScoreRule _regularScoreRule;
        private readonly WinnerRule _winnerRule;

        public Player Server { get; }
        public Player Receiver { get; }

        public Game(string serverName, string receiverName)
        {
            Server = new Player(serverName);
            Receiver = new Player(receiverName);
            _deuceRule = new DeuceScoreRule();
            _regularScoreRule = new RegularScoreRule();
            _winnerRule = new WinnerRule(serverName, receiverName);
        }

        public string ShowScore()
        {
            if (_deuceRule.Match(Server.Point, Receiver.Point))
            {
                return _deuceRule.Score;
            }

            if (_regularScoreRule.Match(Server.Point, Receiver.Point))
            {
                return _regularScoreRule.Score;
            }

            return _winnerRule.Match(Server.Point, Receiver.Point) ? _winnerRule.Score : "";
        }
    }
}