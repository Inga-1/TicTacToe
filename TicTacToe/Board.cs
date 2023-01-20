using System;
using System.Linq;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {

        //we create the initial board 
        public static void Create(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = ".";
                }
            }
        }

        public static void Reset(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != ".")
                    {
                        board[i, j] = ".";
                    }
                }
            }
        }

        public static void PrintOutBoard(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }

        }

        public static bool FreeSpot(string[,] board, int row, int column)
        {
            if (board[row, column] == "X")
            {
                Console.WriteLine("Occupied by the first player on position {0} {1}", row, column);
                return false;

            }
            else if (board[row, column] == "O")
            {
                Console.WriteLine("Occupied by the second player{0} {1}", row, column);
                return false;

            }
            else if (board[row, column] == ".")
            {
                return true;
            }
            else
                throw new Exception();

        }
    }
}
