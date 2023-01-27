using System.Net.NetworkInformation;
using System.Numerics;

namespace TicTacToe
{
    public class PlayerWinnings
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

        public static bool WinByMainDiagonal(string[,] board, int player)

        /*e. g.
         * 
         * X | O | *
         * ---------
         * O | X | O
         * ---------
         * * | * | X
         */
        {
            if ((board[0, 0] == board[1, 1]) && (board[0, 0] == board[2, 2]) && (board[0, 0] == Symbols.SetSymbol(player)))
                return true;
            return false;
        }

        public static bool WinByReverseDiagonal(string[,] board, int player)

        /*e. g.
         * 
         * * | O | X
         * ---------
         * O | X | O
         * ---------
         * X | * | O
         */
        {
            int i = 0;
            if ((board[i + 2, i] == board[i + 1, i + 1]) && (board[i + 1, i + 1] == board[i, i + 2]) && (board[i + 1, i + 1] == Symbols.SetSymbol(player)))
                return true;
            return false;
        }

        public static bool Win(string[,] board, int player)
        {
            return (WinByColumns(board, player) || WinByRows(board, player) || WinByMainDiagonal(board, player) || WinByReverseDiagonal(board, player)) ? true : false;

        }
    }
}
