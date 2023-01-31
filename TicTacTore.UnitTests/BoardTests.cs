using static TicTacToe.Board;
namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class BoardTests
    {
        public Board _board;

        [SetUp]
        public void SetUp()
        {
            _board = new Board();
        }

        [Test]

        public void Reset_WhenCalled_ChangesOtherSymbolsToDots()
        {
            string[,] data = new string[,] { { ".", ".", "." }, { "X", ".", "." }, { ".", "O", "." } };
            Board board = new(data);

            //act
            Reset(board);

            //assert
            Assert.That(board.Boards, Is.EqualTo(_board.Boards));
        }

        [Test]

        public void FreeSpot_WhenXIsFoundAtASpot_ReturnFalse()
        {

            _board.Boards[0, 0] = "X";

            var result = FreeSpot(_board, 0, 0);

            Assert.That(result, Is.False);

        }

        [Test]

        public void FreeSpot_WhenOIsFoundAtASpot_ReturnFalse()
        {

            _board.Boards[0, 0] = "O";

            var result = FreeSpot(_board, 0, 0);

            Assert.That(result, Is.False);

        }

        [Test]

        public void FreeSpot_WhenDotIsFoundAtASpot_ReturnTrue()
        {

            var result = FreeSpot(_board, 0, 0);

            Assert.That(result, Is.True);

        }

        [Test]
        public void FreeSpot_WhenRandomSymbolIsFoundAtASpot_ThrowsException()
        {
            _board.Boards[0, 0] = "&";

            var result = FreeSpot(_board, 0, 0);

            Assert.That(result, Is.EqualTo(false));

        }

        [Test]

        public void IsFull_IfTheBoardIsFullAndNoOneWon_ReturnsTrue()
        {
            _board.Boards[0, 0] = _board.Boards[0, 2] = _board.Boards[1, 2] = _board.Boards[2, 0] = _board.Boards[2, 1] = "X";
            _board.Boards[0, 1] = _board.Boards[1, 0] = _board.Boards[1, 1] = _board.Boards[2, 2] = "O";

            var result = IsFull(_board);
            Assert.That(result, Is.True);

        }

    }
}
