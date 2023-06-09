namespace TennisScore.Console;

public class Game
{
    public readonly Player Player1;
    public readonly Player Player2;
    private State _state;

    private Game(string namePlayer1, string namePlayer2)
    {
        Player1 = Player.Create(namePlayer1);
        Player2 = Player.Create(namePlayer2);
        _state = new InitState();
        _state.SetContext(this);
    }

    public void TransitionTo(State state)
    {
        _state = state;
        _state.SetContext(this);
    }

    public static Game Create(string namePlayer1, string namePlayer2)
    {
        return new Game(namePlayer1, namePlayer2);
    }

    public void WinPoint(Player player)
    {
        _state.WinPoint(player);
    }

    public string GetScore()
    {
        return _state.GetScore();
    }
}