namespace TennisScore.Console;

public class Game
{
    private readonly List<string> _getScoreBoard;

    public Game()
    {
        _getScoreBoard = new List<string> { "love-love" };
    }

    public List<string> GetScoreBoard()
    {
        return _getScoreBoard;
    }

    public void WinPoint()
    {
        if (_getScoreBoard.Count == 1)
        {
            _getScoreBoard.Add("fifteen-love");
        }
        else
        {
            _getScoreBoard.Add("thirty-love");
        }
    }
}