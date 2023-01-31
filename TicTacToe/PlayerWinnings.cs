using System.Net.NetworkInformation;
using System.Numerics;

namespace TicTacToe
{
    public class PlayerWinnings
    {

        public static bool WinByRows(Board board, Player player)
        {

            //int i = 0;
            for (int i = 0; i < 3; i++)
            {
                if ((board.Boards[0, i] == board.Boards[1, i]) && (board.Boards[0, i] == board.Boards[2, i]) && (board.Boards[0, i] == SetSymbol(player.id)))
                {
                    return true;
                }
                else
                    continue;
            }
            return false;
        }


        public static bool WinByColumns(Board board, Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board.Boards[i, 0] == board.Boards[i, 1]) && (board.Boards[i, 0] == board.Boards[i, 2]) && (board.Boards[i, 0] == SetSymbol(player.id)))
                    return true;
                else
                    continue;
            }
            return false;
        }

        public static bool WinByMainDiagonal(Board board, Player player)

        /*e. g.
         * 
         * X | O | *
         * ---------
         * O | X | O
         * ---------
         * * | * | X
         */
        {
            if ((board.Boards[0, 0] == board.Boards[1, 1]) && (board.Boards[0, 0] == board.Boards[2, 2]) && (board.Boards[0, 0] == SetSymbol(player.id)))
                return true;
            return false;
        }

        public static bool WinByReverseDiagonal(Board board, Player player)

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
            if ((board.Boards[i + 2, i] == board.Boards[i + 1, i + 1]) && (board.Boards[i + 1, i + 1] == board.Boards[i, i + 2]) && (board.Boards[i + 1, i + 1] == SetSymbol(player.id)))
                return true;
            return false;
        }

        public static bool Win(Board board, Player player)
        {
            return (WinByColumns(board, player) || WinByRows(board, player) || WinByMainDiagonal(board, player) || WinByReverseDiagonal(board, player));

        }
    }
}
