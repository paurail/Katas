using FluentAssertions;
using Xunit;

namespace tdd_katas
{
    public class RomanNumbersShould
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(8, "VIII")]
        [InlineData(10, "X")]
        [InlineData(19, "XIX")]
        [InlineData(38, "XXXVIII")]
        [InlineData(56, "LVI")]
        public void ConvertFromArabic(int number, string expectedResult)
        {
            var sut = new RomanNumbers();

            sut.Convert(number).Should().Be(expectedResult);
        }
    }
}