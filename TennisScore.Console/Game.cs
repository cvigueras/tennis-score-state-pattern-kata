namespace TennisScore.Console;

public class Game
{
    public readonly Player Player1;
    public readonly Player Player2;
    private State _state = null;

    private Game(string namePlayer1, string namePlayer2, State state)
    {
        Player1 = Player.Create(namePlayer1);
        Player2 = Player.Create(namePlayer2);
        TransitionTo(state);
    }

    public void TransitionTo(State state)
    {
        _state = state;
        _state.SetContext(this);
    }

    public static Game Create(string namePlayer1, string namePlayer2, State state)
    {
        return new Game(namePlayer1, namePlayer2, state);
    }
    public void WinPoint(Player player)
    {
        _state.WinPoint(player);
    }

    public string GetScore()
    {
        return _state.GetScore();
    }

    public Enum GetScorePlayer1()
    {
        return Player1.Score;
    }

    public Enum GetScorePlayer2()
    {
        return Player2.Score;
    }

    public Enum HasDeuce()
    {
        if (Player1.Score == Score.Forty && Player1.Score == Player2.Score)
        {
            return Score.Deuce;
        }

        return Score.None;
    }

    public string HasAdvantage()
    {
        if (Player1.Score == Score.Advantage && Player2.Score == Score.Forty)
        {
            return Score.Advantage + " " + Player1.Name;
        }
        if (Player2.Score == Score.Advantage && Player1.Score == Score.Forty)
        {
            return Score.Advantage + " " + Player2.Name;
        }

        return Score.None.ToString();
    }
}