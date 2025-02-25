namespace Romertal.Test
{
    public class IntToRomanNumeralTest
    {
        [Theory]
        [InlineData(7, "VII")]
        [InlineData(13, "XIII")]
        [InlineData(1999, "MCMXCIX")]
        [InlineData(2444, "MMCDXLIV")]
        [InlineData(90, "XC")]
        [InlineData(2, "II")]
        [InlineData(5, "V")]
        [InlineData(2000, "MM")]
        public void AssertIntToRomanNumerals(int input, string expected)
        {
            string result = IntToRomanNumeralService.ConvertFromIntToRomanNumerals(input);
            Assert.Equal(expected, result);
        }
    }
}