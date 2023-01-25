using System.Numerics;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class SymbolsTests
    {
        //private int _player;

        [Test]
        [TestCase(1, "X")]
        [TestCase(2, "O")]
        public void SetSymbol_ValidPlayer_ReturnAppropriateString(int player, string expectedResult)
        {
            //Act
            var result = Symbols.SetSymbol(player);

            //Assert
            Assert.That( result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SetSymbol_InvalidPlayer_ThrowArgOutOfRangeException()
        {
            var result = Symbols.SetSymbol(3);

            Assert.That(result, Is.EqualTo(""));
        }

    }
}
