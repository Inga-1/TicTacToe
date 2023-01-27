namespace TicTacToe
{
    internal static class DisplayMethods
    {

        public static void InitialMessageDisplay()
        {
            Console.WriteLine("Welcome to Tic Tac Toe game! \nIf you want to familiarize yourself with the rules of the game, please type Y. \nTo jump right in type N ");
        }

        public static void RuleDisplay()
        {
            Console.WriteLine("The game is fairly simple; it is for 2 players, and there are 4 potential ways to win. \nYou can win by rows, columns, main diagonal, or by the reverse diagonal");
            Console.WriteLine("To win by columns, you have to manage to get 3 of your symbols in one line before your opponent does.\nThe same applies to all the other ways to win: you have to get 3 of your symbols one after another in the corresponding manner.");

        }

        public static void ExampleDisplay()
        {
            Console.WriteLine("O O O \n* * * \n* * * \nHere, player 2 wins by rows\nX * * \n* X * \n* * X \nHere, player 1 wins by the main diagonal");
        }
        public static void AfterRuleDisplay()
        {
            Console.WriteLine("Are the rules of the game clear? \nY or N");
        }

        public static void StartOfTheGame()
        {
            Console.WriteLine("Let's get started! Good Luck! \nIt is now player 1's turn. \nPlease choose the position for your first move.");
        }
        public static void ReadingPositon(string[] position)
        {
            Console.WriteLine("Row: ");
            position[0] = Console.ReadLine();
            Console.WriteLine("Column: ");
            position[1] = Console.ReadLine();
        }

        public static string[] ChooseTheRowAndColumn()
        {
            string[] position = new string[2];

            ReadingPositon(position);
            while (position[0] == "" || position[1] == "") //FIX THIS FOR INVALID INPUTS TOO
            {
                Console.WriteLine("Please enter a valid position");
                ReadingPositon(position);

            }
            return position;

        }

        public static void OccupiedSpotFound()
        {
            Console.WriteLine("This spot is occupied, please choose another one");
        }

        public static void FullBoardDisplay()
        {
            Console.WriteLine("Oh no, it looks like no one won! \nWould you like to play again?");

        }

        public static void WrongFormatDisplay()
        {
            Console.WriteLine("Argument is in the wrong format. \nPlease choose a number between 1 and 3.");
        }

        public static string PlayAgainDisplay()
        {
            Console.WriteLine("Would you like to play again? \nY or N");
            string answer = Console.ReadLine();
            
            if(answer == "Y" || answer == "N")
            {
                return answer;
            }
            else
            {
                answer = Console.ReadLine();
            }
            return answer;
        }

    }
}