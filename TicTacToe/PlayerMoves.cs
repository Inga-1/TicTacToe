namespace TicTacToe
{
    internal class PlayerMoves
    {
        public static void Move(int player)
        {
            //switches between player moves

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
    }
}
