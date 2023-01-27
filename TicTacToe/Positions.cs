namespace TicTacToe
{
    public class Positions
    {
        public static int PositionParsing(string input) 
        {
            int result;

            try
            {
                if(input == "1" || input == "2" || input == "3")
                    result = Convert.ToInt32(input);
                else
                    throw new Exception();
            }
            catch(Exception)
            {
                result = -1;
            }
            return result;
        }
    }
}
