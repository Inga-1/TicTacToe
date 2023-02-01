namespace TicTacToe
{
    internal static class DisplayMethods
    {

        public static void InitialMessageDisplay()
        {
            WriteLine("Welcome to Tic Tac Toe game! \nIf you want to familiarize yourself with the rules of the game, please type Y. \nTo jump right in type N ");
        }

        public static void RuleDisplay()
        {
            WriteLine("The game is fairly simple; it is for 2 players, and there are 4 potential ways to win. \nYou can win by rows, columns, main diagonal, or by the reverse diagonal");
            WriteLine("To win by columns, you have to manage to get 3 of your symbols in one line before your opponent does.\nThe same applies to all the other ways to win: you have to get 3 of your symbols one after another in the corresponding manner.");

        }

        public static void ExampleDisplay()
        {
            WriteLine("O O O \n* * * \n* * * \nHere, player 2 wins by rows\nX * * \n* X * \n* * X \nHere, player 1 wins by the main diagonal");
        }
        public static void AfterRuleDisplay()
        {
            WriteLine("Are the rules of the game clear? \nY or N");
        }

        public static void StartOfTheGame()
        {
            WriteLine("Let's get started! Good Luck! \nIt is now player 1's turn. \nPlease choose the position for your first move.");
        }
        public static void ReadingPositon(string[] position)
        {
            WriteLine("Row: ");
            position[0] = ReadLine().ToUpper();
            WriteLine("Column: ");
            position[1] = ReadLine().ToUpper();
        }

        public static string[] ChooseTheRowAndColumn()
        {
            string[] position = new string[2];

            ReadingPositon(position);
            while (position[0] == "" || position[1] == "")
            {
                WriteLine("Please enter a valid position");
                ReadingPositon(position);

            }
            return position;

        }

        public static void OccupiedSpotFound()
        {
            WriteLine("This spot is occupied, please choose another one");
        }

        public static void FullBoardDisplay()
        {
            WriteLine("Oh no, it looks like no one won! \nWould you like to play again?");

        }

        public static void WrongFormatDisplay()
        {
            WriteLine("Argument is in the wrong format. \nPlease choose a number between 1 and 3.");
        }

        public static string PlayAgainDisplay()
        {
            WriteLine("Would you like to play again? \nY or N");
            string answer = ReadLine().ToUpper();

            if (answer == "Y" || answer == "N")
            {
                return answer;
            }
            else
            {
                answer = ReadLine().ToUpper();
            }
            return answer;
        }

    }
}