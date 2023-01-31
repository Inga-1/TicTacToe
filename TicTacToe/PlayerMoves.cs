namespace TicTacToe
{
    internal class PlayerMoves 
    {
        public static void Move(Player player)
        {
            //switches between player moves

            if (player.id == 1)
            {
                WriteLine("It is the first player's move");

            }
            else if (player.id == 2)
            {
                WriteLine("It is the second player's move");
            }
            else
            {
                throw new Exception("Unknown Player");
            }
        }
    }
}
