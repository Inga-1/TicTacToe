namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class PositionsTests
    {
        [Test]

        public void PositionsParsing_WhenInputIsValid_ReturnsTheInt()
        {
            string input = "1";
            int result = Positions.PositionParsing(input);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]

        public void PositionsParsing_WhenInputIsANegativeNumber_ReturnsNegative1()
        {
            string input = "-1";
            int result = Positions.PositionParsing(input);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]

        public void PositionsParsing_WhenInputIsALetter_ReturnsNegative1()
        {
            string input = "a";
            int result = Positions.PositionParsing(input);
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}
