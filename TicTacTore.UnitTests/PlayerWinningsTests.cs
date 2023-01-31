using static TicTacToe.PlayerWinnings;
namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class PlayerWinningsTests
    {
        private Board _board;
        private Player _player;

        [SetUp]
        public void SetUp()
        {
            _board = new();
            _player = new();
        }

        [Test]

        public void WinByRows_Player1WinsByFirstRow_ReturnTrue()
        {

            for (int i = 0; i < 3; i++)
            {
                _board.Boards[i, 0] = "X";
            }

            var result = WinByRows(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByRows_Player2WinsByFirstRow_ReturnTrue()
        {
            _player.id = 2;
            for (int i = 0; i < 3; i++)
            {
                _board.Boards[i, 0] = "O";
            }

            var result = WinByRows(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByRows_Player1WinsBySecondRow_ReturnTrue()
        {

            for (int i = 0; i < 3; i++)
            {
                _board.Boards[i, 1] = "X";
            }
                
            var result = WinByRows(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByColumn_Player1WinsBySecondColumn_ReturnTrue()
        {
            for (int i = 0; i < 3; i++)
            {
                _board.Boards[1, i] = "X";
            }

            var result = WinByColumns(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByColumns_Player2WinsBySecondColumn_ReturnTrue()
        {
            _player.id = 2;
            for (int i = 0; i < 3; i++)
                _board.Boards[1, i] = "O";

            var result = WinByColumns(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByMainDiagonal_Player1WinsByDiagonal_ReturnTrue()
        {
            for (int i = 0; i < 3; i++)
                _board.Boards[i, i] = "X";

            var result = WinByMainDiagonal(_board, _player);
                
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByReverseDiagonal_Player2WinsByReverseDiagonal_ReturnTrue()
        {
            _player.id = 2;
            _board.Boards[2, 0] = "O";
            _board.Boards[1, 1] = "O";
            _board.Boards[0, 2] = "O";


            var result = WinByReverseDiagonal(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }
    }
}