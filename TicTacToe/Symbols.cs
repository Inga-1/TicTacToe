﻿using System;

namespace TicTacToe
{
    public class Symbols
    {
        private string symbol;

        public Symbols(string symbol)
        {
            this.symbol = symbol;
        }

        public static string SetSymbol(int player)
        {
            if (player == 1)
            {
                return ("X");
            }
            else if (player == 2)
            {
                return "O";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

}