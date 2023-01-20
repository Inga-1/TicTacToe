namespace TicTacToe
{
    internal class Program
    {

        private static void Main()
        {
            string[,] board = new string[3, 3];

            Board.Create(board);
            board[0, 1] = "X";
            board[1, 1] = "X";
            board[2, 1] = "X";

            Board.PrintOutBoard(board);
            //if (Player.WinByRowsPlayer1(board))
            //{
            //    Console.WriteLine("Player 1 won");

            //}
        }

    }
}



       

//board.Reset();