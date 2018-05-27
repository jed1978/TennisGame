namespace TennisGame
{
    public interface IScoreRule
    {
        string Score { get; }
        bool Match(int serverPoint, int receiverPoint);
    }
}