using System;

namespace TennisGame
{
    public class Game
    {
        private string _server;
        private string _receiver;
        private int _playerOneScore;
        private int _playerTwoScore;  

        public Game(string server, string receiver)
        {
            this._server = server;
            this._receiver = receiver;
        }

        public string Score()
        {
            var score = "";

            if (_playerOneScore == _playerTwoScore)
                score = TranslatePointToScore(_playerOneScore) + " All";
            else
                score = TranslatePointToScore(_playerOneScore) + " " + TranslatePointToScore(_playerTwoScore);
            return score;
        }

        public string Point()
        {
            var score = "";

            score = TranslatePoint(_playerOneScore) + ":" + TranslatePoint(_playerTwoScore);
            return score;

        }

        public void PlayerTwoWinPoint()
        {
            _playerTwoScore++;
        }

        /// <summary>
        /// PlayerOne得分
        /// </summary>
        public void PlayerOneWinPoint()
        {
            _playerOneScore++;
        }

        private string TranslatePointToScore(int point)
        {
            var score = "";
            switch (point)
            {
                case 1:
                    score = "Fifteen";
                    break;
                case 2:
                    score = "Thirty";
                    break;
                case 3:
                    score = "Forty";
                    break;
                default:
                    score = "Love";
                    break;
            }

            return score;
        }

        private string TranslatePoint(int point)
        {
            var score = "";
            switch (point)
            {
                case 1:
                    score = "15";
                    break;
                case 2:
                    score = "30";
                    break;
                case 3:
                    score = "40";
                    break;
                default:
                    score = "0";
                    break;
            }

            return score;
        }
    }
}