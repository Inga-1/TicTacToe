﻿using TicTacToe;
namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class BoardTests
    {
        private string[,] _board;

        [SetUp]
        public void SetUp()
        {
            _board = new string[,] { { ".", ".", "." }, { ".", ".", "." }, { ".", ".", "." } };
        }


        [Test]

        //testing if Create() creates the right board 
        public void Create_WhenCalled_GeneratesASquareOfDots()
        {
            string[,] board = new string[3, 3];

            Board.Create(board);

            Assert.That(board, Is.EqualTo(_board));
        }

        [Test]

        public void Reset_WhenCalled_ChangesOtherSymbolsToDots()
        {
            string[,] board = new string[,] { { "X", ".", "." }, { ".", "O", "." }, { ".", ".", "." } };

            Board.Reset(board);

            Assert.That(board, Is.EqualTo(_board));
        }

        [Test]

        public void FreeSpot_WhenXIsFoundAtASpot_ReturnFalse()
        {

            _board[0, 0] = "X";

            var result = Board.FreeSpot(_board, 0, 0);

            Assert.That(result, Is.False);

        }

        [Test]

        public void FreeSpot_WhenOIsFoundAtASpot_ReturnFalse()
        {

            _board[0, 0] = "O";

            var result = Board.FreeSpot(_board, 0, 0);

            Assert.That(result, Is.False);

        }

        [Test]

        public void FreeSpot_WhenDotIsFoundAtASpot_ReturnTrue()
        {

            var result = Board.FreeSpot(_board, 0, 0);

            Assert.That(result, Is.True);

        }

        [Test]
        public void FreeSpot_WhenRandomSymbolIsFoundAtASpot_ThrowsException()
        {
            _board[0, 0] = "&";

            var result = Board.FreeSpot(_board, 0, 0);

            Assert.That(result, Is.EqualTo(false));

        }

        [Test]

        public void IsFull_IfTheBoardIsFullAndNoOneWon_ReturnsTrue()
        {
            _board[0, 0] = _board[0, 2] = _board[1, 2] = _board[2, 0] = _board[2, 1] = "X";
            _board[0, 1] = _board[1, 0] = _board[1, 1] = _board[2, 2] = "O";

            var result = Board.IsFull(_board);
            Assert.That(result, Is.True);

        }

    }
}
