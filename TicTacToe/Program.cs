namespace TicTacToe
{
    internal class Program
    {

        private static void Main()
        {
            string[,] board = new string[3, 3];
            int player = 1;

            Board.Create(board);
            DisplayMethods.InitialMessageDisplay();

            var userReply = Console.ReadLine();


            if (userReply == "Y")
            {
                DisplayMethods.RuleDisplay();
                DisplayMethods.AfterRuleDisplay();
                var replyOnStartingTheGame = Console.ReadLine(); //getting the new reply to understand if there should be further instructions or if the game should start 
                if (replyOnStartingTheGame == "Y")
                {
                    DisplayMethods.StartOfTheGame();
                    Board.PrintOutBoard(board);
                }
                else
                {
                    DisplayMethods.ExampleDisplay();
                    DisplayMethods.StartOfTheGame();
                    Board.PrintOutBoard(board);
                }
            }
            else
            {
                DisplayMethods.StartOfTheGame();
                Board.PrintOutBoard(board);
            }

            while (true){

                string[] position = DisplayMethods.ChooseTheRowAndColumn();
                int row = Positions.PositionParsing(position[0]);
                int column = Positions.PositionParsing(position[1]);

                if(row == -1 || column == -1)
                    DisplayMethods.WrongFormatDisplay();

                else
                {
                    if (Board.FreeSpot(board, row - 1, column - 1))
                    {
                        board[row - 1, column - 1] = Symbols.SetSymbol(player);
                        Board.PrintOutBoard(board);

                        if (PlayerWinnings.Win(board, player))
                        {
                            Console.WriteLine("CONGRATULATIONS, PLAYER {0} YOU ARE THE WINNER!", player);
                            string answer = DisplayMethods.PlayAgainDisplay();
                            if (answer == "Y")
                                Board.Reset(board);
                            else
                                break;
                        }
                        else
                        {
                            player++;
                            player = player % 2 == 0 ? 2 : 1;
                            if (!Board.IsFull(board))
                                Console.WriteLine("It is now player {0}'s turn", player);
                            else
                            {
                                DisplayMethods.FullBoardDisplay();
                                break;
                            }
                        }
                    }
                    else 
                    {
                        DisplayMethods.OccupiedSpotFound();
                        Board.PrintOutBoard(board);
                    }
                }
            }
        }
    }
}
