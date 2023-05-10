using TDDKataCalc;

namespace TDDKata
{
    public class CalcUnitTests
    {
        [Fact]
        public void EmptyStringShouldReturnZero()
        {
            // Arrange
            string input = "";
            int expected = 0;
            Calc calc = new();

            // Act
            var actual = calc.Add(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneDigitShouldThrowError()
        {
            // Arrange
            string input = "1";
            int expected = -1;
            Calc calc = new();

            // Act
            var actual = calc.Add(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoDigitsShouldReturnResult()
        {
            // Arrange
            string input = "1,3";
            int expected = 4;
            Calc calc = new();

            // Act
            var actual = calc.Add(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}