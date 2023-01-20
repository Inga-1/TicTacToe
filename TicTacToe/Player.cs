namespace TicTacToe
{
    public class Player
    {

        public static bool WinByRows(string[,] board, int player)
        {

            //int i = 0;
            for (int i = 0; i < 3; i++)
            {
                if ((board[0, i] == board[1, i]) && (board[0, i] == board[2, i]) && (board[0, i] == Symbols.SetSymbol(player)))
                {
                    return true;
                }
                else
                    continue;
            }
            return false;
        }


        public static bool WinByColumns(string[,] board, int player)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == board[i, 1]) && (board[i, 0] == board[i, 2]) && (board[i, 0] == Symbols.SetSymbol(player)))
                {
                    return true;
                }
                else
                    continue;
            }
            return false;
        }

        public void Move(int player)
        {
            if (player == 1)
            {
                Console.WriteLine("It is the first player's move");

            }
            else if (player == 2)
            {
                Console.WriteLine("It is the second player's move");
            }
            else
            {
                throw new Exception("Unknown Player");
            }
        }

        public void Win()
        {

        }
    }
}
