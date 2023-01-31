using System.Numerics;
using static TicTacToe.Symbols;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class SymbolsTests
    {

        [Test]
        [TestCase(1, "X")]
        [TestCase(2, "O")]
        public void SetSymbol_ValidPlayer_ReturnAppropriateString(int player, string expectedResult)
        {
            //Act
            var result = SetSymbol(player);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SetSymbol_InvalidPlayer_ThrowArgOutOfRangeException()
        {
            var result = SetSymbol(3);

            Assert.That(result, Is.EqualTo(""));
        }

    }
}
