using TDDKataCalc;

namespace TDDKata
{
    public class CalcUnitTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,3", 4)]
        [InlineData("1\n2,3", 6)]
        public void ValidInputShouldReturnResult(string input, int expected)
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
        [InlineData("1,\n", -1)]
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