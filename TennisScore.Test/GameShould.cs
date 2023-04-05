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
            _game = Game.Create("Rafa Nadal","Carlos Alcaraz");
        }

        [Test]
        public void return_love_love_when_game_start()
        {
            var expectedScorePlayer1 = Score.Love;
            var expectedScorePlayer2 = Score.Love;

            var scorePlayer1 = _game.GetScorePlayer1();
            var scorePlayer2 = _game.GetScorePlayer2();

            scorePlayer1.Should().BeEquivalentTo(expectedScorePlayer1);
            scorePlayer2.Should().BeEquivalentTo(expectedScorePlayer2);
        }

        [Test]
        public void add_fifteen_love_to_score_board_when_player1_win_first_point()
        {
            var expectedScorePlayer1 = Score.Fifteen;
            var expectedScorePlayer2 = Score.Love;
            _game.WinPoint(_game.Player1);

            var scorePlayer1 = _game.GetScorePlayer1();
            var scorePlayer2 = _game.GetScorePlayer2();

            scorePlayer1.Should().BeEquivalentTo(expectedScorePlayer1);
            scorePlayer2.Should().BeEquivalentTo(expectedScorePlayer2);
        }

        [Test]
        public void add_thirty_love_to_score_board_when_player1_win_second_point()
        {
            var expectedScorePlayer1 = Score.Thirty;
            var expectedScorePlayer2 = Score.Love;
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player1);

            var scorePlayer1 = _game.GetScorePlayer1();
            var scorePlayer2 = _game.GetScorePlayer2();

            scorePlayer1.Should().BeEquivalentTo(expectedScorePlayer1);
            scorePlayer2.Should().BeEquivalentTo(expectedScorePlayer2);
        }

        [Test]
        public void add_forty_love_to_score_board_when_player1_win_third_point()
        {
            var expectedScorePlayer1 = Score.Forty;
            var expectedScorePlayer2 = Score.Love;
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player1);
            _game.WinPoint(_game.Player1);

            var scorePlayer1 = _game.GetScorePlayer1();
            var scorePlayer2 = _game.GetScorePlayer2();

            scorePlayer1.Should().BeEquivalentTo(expectedScorePlayer1);
            scorePlayer2.Should().BeEquivalentTo(expectedScorePlayer2);
        }

        [Test]
        public void add_love_fifteen_to_score_board_when_player2_win_first_point()
        {
            var expectedScorePlayer1 = Score.Love;
            var expectedScorePlayer2 = Score.Fifteen;
            _game.WinPoint(_game.Player2);

            var scorePlayer1 = _game.GetScorePlayer1();
            var scorePlayer2 = _game.GetScorePlayer2();

            scorePlayer1.Should().BeEquivalentTo(expectedScorePlayer1);
            scorePlayer2.Should().BeEquivalentTo(expectedScorePlayer2);
        }

        [Test]
        public void add_love_thirty_to_score_board_when_player2_win_second_point()
        {
            var expectedScorePlayer1 = Score.Love;
            var expectedScorePlayer2 = Score.Thirty;
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player2);

            var scorePlayer1 = _game.GetScorePlayer1();
            var scorePlayer2 = _game.GetScorePlayer2();

            scorePlayer1.Should().BeEquivalentTo(expectedScorePlayer1);
            scorePlayer2.Should().BeEquivalentTo(expectedScorePlayer2);
        }

        [Test]
        public void add_love_forty_to_score_board_when_player2_win_third_point()
        {
            var expectedScorePlayer1 = Score.Love;
            var expectedScorePlayer2 = Score.Forty;
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player2);
            _game.WinPoint(_game.Player2);

            var scorePlayer1 = _game.GetScorePlayer1();
            var scorePlayer2 = _game.GetScorePlayer2();

            scorePlayer1.Should().BeEquivalentTo(expectedScorePlayer1);
            scorePlayer2.Should().BeEquivalentTo(expectedScorePlayer2);
        }
    }
}