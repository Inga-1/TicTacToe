

namespace TicTacToe
{

    internal class Program
    {

        private static void Main()
        {
            Board board = new();

            Player player = new();

            InitialMessageDisplay();

            var userReply = ReadLine();


            if (userReply == "Y")
            {
                RuleDisplay();
                AfterRuleDisplay();
                var replyOnStartingTheGame = ReadLine(); //getting the new reply to understand if there should be further instructions or if the game should start 
                if (replyOnStartingTheGame == "Y")
                {
                    StartOfTheGame();
                    PrintOutBoard(board);
                }
                else
                {
                    ExampleDisplay();
                    StartOfTheGame();
                    PrintOutBoard(board);
                }
            }
            else
            {
                StartOfTheGame();
                PrintOutBoard(board);
            }

            while (true)
            {

                string[] position = ChooseTheRowAndColumn();
                int row = PositionParsing(position[0]);
                int column = PositionParsing(position[1]);

                if (row == -1 || column == -1)
                    WrongFormatDisplay();

                else
                {
                    if (FreeSpot(board, row - 1, column - 1))
                    {
                        board.Boards[row - 1, column - 1] = SetSymbol(player.id);
                        PrintOutBoard(board);

                        if (Win(board, player))
                        {
                            WriteLine("CONGRATULATIONS, PLAYER {0} YOU ARE THE WINNER!", player.id);
                            string answer = PlayAgainDisplay();
                            if (answer == "Y")
                                Reset(board);
                            else
                                break;
                        }
                        else
                        {
                            player.id++;
                            player.id = player.id % 2 == 0 ? 2 : 1;
                            if (!IsFull(board))
                                WriteLine("It is now player {0}'s turn", player.id);
                            else
                            {
                                FullBoardDisplay();
                                break;
                            }
                        }
                    }
                    else
                    {
                        OccupiedSpotFound();
                        PrintOutBoard(board);
                    }
                }
            }
        }
    }
}
