using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

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

            if ((board[row, column] == "X") || (board[row, column] == "O"))
            {
                return false; //false

            }
            else if (board[row, column] == ".")
            {
                return true; //true 
            }
            return false;

        }

        public static bool IsFull(string[,] board)
        {
            foreach(string position in board)
            {
                if(position == ".")
                {
                    return false;
                }
                continue;
            }
            return true;
        }

    }
}
