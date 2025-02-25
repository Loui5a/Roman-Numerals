namespace Romertal.Test
{
    public class RomanNumeralToIntTest
    {
        [Theory]
        [InlineData("VII", 7)]
        [InlineData("XIII", 13)]
        [InlineData("MCMXCIX", 1999)]
        [InlineData("MMCDXLIV", 2444)]
        [InlineData("XC", 90)]
        [InlineData("II", 2)]
        [InlineData("V", 5)]
        [InlineData("MM", 2000)]
        public void AssertRomanNumeralToInt(string input, int expected)
        {
            int result = RomanNumeralsToIntService.Convert(input);
            Assert.Equal(expected, result);
        }

    }
}
