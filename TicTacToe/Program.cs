namespace TicTacToe
{
    internal class Program
    {

        private static void Main()
        {
            string[,] board = new string[3, 3];

            Board.Create(board);
            //board[0, 0] = "X";
            //board[1, 1] = "X";
            //board[2, 2] = "X";

            board[2, 0] = "O";
            board[1, 1] = "O";
            board[0, 2] = "O";

            Board.PrintOutBoard(board);

            if (Board.FreeSpot(board, 0, 2) == false)
            {
                Console.WriteLine("oops");
            }

            //Console.WriteLine("Oops");
            //if (Player.WinByReverseDiagonal(board, 2))
            //{
            //    Console.WriteLine("IT WORKED!");
            //}
            //else { Console.WriteLine("Nope sorry"); }
        }

    }
}



       

//board.Reset();