using System;

namespace TicTacToe
{
    public class Symbols
    {

        public static string SetSymbol(int player)
        {
            try
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
            catch (ArgumentOutOfRangeException)
            {
                WriteLine("Invalid Player");
                return "";
            }
        }
    }

}
