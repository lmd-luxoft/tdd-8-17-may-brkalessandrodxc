using TDDKataCalc;

namespace TDDKata
{
    public class CalcUnitTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,3", 4)]
        public void UpToTwoDigitsShouldReturnResult(string input, int expected)
        {
            // Arrange
            Calc calc = new();

            // Act
            var actual = calc.Add(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, -1)]
        [InlineData("test", -1)]
        public void InvalidInputShouldThrowError(string input, int expected)
        {
            // Arrange
            Calc calc = new();

            // Act
            var actual = calc.Add(input);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}