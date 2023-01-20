namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class PlayerTests
    {
        private string[,] _board;
        private int _player;

        [SetUp]
        public void SetUp()
        {
            _board = new string[,] { { ".", ".", "." }, { ".", ".", "." }, { ".", ".", "." } };
            _player = 1; 
        }

        [Test]

        public void WinByRows_Player1WinsByFirstRow_ReturnTrue()
        {

            for (int i = 0; i < 3; i++)
            {
                _board[i, 0] = "X";
            }

            var result = Player.WinByRows(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByRows_Player2WinsByFirstRow_ReturnTrue()
        {
            _player = 2;
            for (int i = 0; i < 3; i++)
            {
                _board[i, 0] = "O";
            }

            var result = Player.WinByRows(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByRows_Player1WinsBySecondRow_ReturnTrue()
        {

            for (int i = 0; i < 3; i++)
            {
                _board[i, 1] = "X";
            }

            var result = Player.WinByRows(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByColumn_Player1WinsBySecondColumn_ReturnTrue()
        {
            for (int i = 0; i < 3; i++)
            {
                _board[1, i] = "X";
            }

            var result = Player.WinByColumns(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]

        public void WinByColumns_Player2WinsBySecondColumn_ReturnTrue()
        {
            _player = 2;
            for (int i = 0; i < 3; i++)
            {
                _board[1, i] = "O";
            }

            var result = Player.WinByColumns(_board, _player);

            Assert.That(result, Is.EqualTo(true));
        }


    }
}