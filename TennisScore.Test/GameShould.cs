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
            _game = new Game();
        }

        [Test]
        public void return_love_love_when_game_start()
        {
            var expectedResult = new List<string> {"love-love"};

            var result = _game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void add_fifteen_love_to_score_board_when_player1_win_first_point()
        {
            var expectedResult = new List<string>{
                {"love-love"},
                {"fifteen-love"},
            };

            _game.WinPoint("Player1");

            var result = _game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void add_thirty_love_to_score_board_when_player1_win_second_point()
        {
            var expectedResult = new List<string>{
                {"love-love"},
                {"fifteen-love"},
                {"thirty-love"},
            };

            _game = new Game();
            _game.WinPoint("Player1");
            _game.WinPoint("Player1");

            var result = _game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void add_forty_love_to_score_board_when_player1_win_third_point()
        {
            var expectedResult = new List<string>{
                {"love-love"},
                {"fifteen-love"},
                {"thirty-love"},
                {"forty-love"},
            };

            _game = new Game();
            _game.WinPoint("Player1");
            _game.WinPoint("Player1");
            _game.WinPoint("Player1");

            var result = _game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void add_love_fifteen_to_score_board_when_player2_win_first_point()
        {
            var expectedResult = new List<string>{
                {"love-love"},
                {"love-fifteen"},
            };

            _game.WinPoint("Player2");

            var result = _game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void add_love_thirty_to_score_board_when_player2_win_second_point()
        {
            var expectedResult = new List<string>{
                {"love-love"},
                {"love-fifteen"},
                {"love-thirty"},
            };

            _game.WinPoint("Player2");
            _game.WinPoint("Player2");

            var result = _game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}