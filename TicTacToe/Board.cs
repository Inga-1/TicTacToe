namespace TicTacToe
{
    public class Board
    {
        public readonly string[,] Boards;
        public Board()
        {
            Boards = new string[,] { { ".", ".", "." }, { ".", ".", "." }, { ".", ".", "." } };
        }

        public Board(string[,] boards)

        {
            Boards = boards;
        }

        public static void Reset(Board board)
        {
            for (int i = 0; i < board.Boards.GetLength(0); i++)
            {
                for (int j = 0; j < board.Boards.GetLength(1); j++)
                {
                    if (board.Boards[i, j] != ".")
                        board.Boards[i, j] = ".";
                }
            }
        }

        public static void PrintOutBoard(Board board)
        {
            for (int i = 0; i < board.Boards.GetLength(0); i++)
            {
                for (int j = 0; j < board.Boards.GetLength(1); j++)
                    Write(board.Boards[i, j]);
                WriteLine();
            }
        }

        public static bool FreeSpot(Board board)
        {
            foreach (string position in board.Boards)
            {
                if (position == ".")
                    return false;
                continue;
            }
            return true;

        }

        public static bool FreeSpot(Board board, int row, int column)
        {

            if ((board.Boards[row, column] == "X") || (board.Boards[row, column] == "O"))
                return false;
            else if (board.Boards[row, column] == ".")
                return true;
            return false;
        }
    }
}
