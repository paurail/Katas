using FluentAssertions;
using Xunit;

namespace tdd_katas.RomanNumbers
{
    public class RomanNumbersShould
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(4, "IV")]
        [InlineData(10, "X")]
        [InlineData(56, "LVI")]
        [InlineData(290, "CCXC")]
        [InlineData(1066, "MLXVI")]
        [InlineData(1989, "MCMLXXXIX")]
        public void ConvertFromArabic(int number, string expectedResult)
        {
            var sut = new RomanNumbers();

            sut.Convert(number).Should().Be(expectedResult);
        }
    }
}