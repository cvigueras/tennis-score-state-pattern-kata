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

    public void WinPoint(Player player)
    {
        if (player.Value == "Player1")
        {
            if (_getScoreBoard.Count == 1)
            {
                _getScoreBoard.Add("fifteen-love");
            }
            else if (_getScoreBoard.Count == 2)
            {
                _getScoreBoard.Add("thirty-love");
            }
            else
            {
                _getScoreBoard.Add("forty-love");
            }
        }
        else if (player.Value == "Player2")
        {
            if (_getScoreBoard.Count == 1)
            {
                _getScoreBoard.Add("love-fifteen");
            }
            else if (_getScoreBoard.Count == 2)
            {
                _getScoreBoard.Add("love-thirty");
            }
            else if (_getScoreBoard.Count == 3)
            {
                _getScoreBoard.Add("love-forty");
            }
        }
    }
}