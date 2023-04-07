using FluentAssertions;
using TennisScore.Console;

namespace TennisScore.Test
{
    public class GameShould
    {
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _game = Game.Create("Rafa Nadal", "Carlos Alcaraz");
        }

        [Test]
        public void return_love_love_when_game_start()
        {
            var expectedScore = Score.Love + "-" + Score.Love;

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void add_fifteen_love_to_score_board_when_player1_win_first_point()
        {
            var expectedScore = Score.Fifteen + "-" + Score.Love;
            _game.WinPoint(_game.Player1);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void add_thirty_love_to_score_board_when_player1_win_second_point()
        {
            var expectedScore = Score.Thirty + "-" + Score.Love;
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player1);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void add_forty_love_to_score_board_when_player1_win_third_point()
        {
            var expectedScore = Score.Forty + "-" + Score.Love;
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player1);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void add_love_fifteen_to_score_board_when_player2_win_first_point()
        {
            var expectedScore = Score.Love + "-" + Score.Fifteen;
            _game.WinPoint(_game.Player2);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void add_love_thirty_to_score_board_when_player2_win_second_point()
        {
            var expectedScore = Score.Love + "-" + Score.Thirty;
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player2);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void add_love_forty_to_score_board_when_player2_win_third_point()
        {
            var expectedScore = Score.Love + "-" + Score.Forty;
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player2);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void add_fifteen_fifteen_to_score_board_when_player1_and_player2_win_first_point()
        {
            var expectedScore = Score.Fifteen + "-" + Score.Fifteen;
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void get_deuce_when_player1_has_forty_and_player2_has_forty()
        {
            var expectedScore = Score.Deuce.ToString();
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void get_advantage_for_player1_when_player1_has_advantage()
        {
            var expectedScore = Score.Advantage + " " + _game.Player1.Name;
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void get_advantage_for_player2_when_player2_has_advantage()
        {
            var expectedScore = Score.Advantage + " " + _game.Player2.Name;
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void get_win_player1_when_player1_win()
        {
            var expectedScore = Score.Winner + " " + _game.Player1.Name;
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player1);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }

        [Test]
        public void get_win_player2_when_player2_win()
        {
            var expectedScore = Score.Winner + " " + _game.Player2.Name;
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player2);

            var score = _game.GetScore();

            score.Should().BeEquivalentTo(expectedScore);
        }
    }
}