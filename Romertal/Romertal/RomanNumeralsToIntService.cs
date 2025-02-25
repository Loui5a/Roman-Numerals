namespace Romertal
{
    public class RomanNumeralsToIntService
    {
        /// <summary>
        /// Convert iterates through the input string,
        /// converts the roman numeral to an integer using the method ConvertSingleRomanNumeralToInt,
        /// convertedValues are summed before returned.
        /// </summary>
        public static int Convert(string input)
        {
            List<int> convertedValues = [];
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (ConvertSingleRomanNumeralToInt(input[i]) > ConvertSingleRomanNumeralToInt(input[i + 1]))
                {
                    convertedValues.Add(ConvertSingleRomanNumeralToInt(input[i]));
                }
                else if (ConvertSingleRomanNumeralToInt(input[i]) < ConvertSingleRomanNumeralToInt(input[i + 1]))
                {
                    convertedValues.Add(ConvertSingleRomanNumeralToInt(input[i]) * -1);
                }
                else if (ConvertSingleRomanNumeralToInt(input[i]) == ConvertSingleRomanNumeralToInt(input[i + 1]))
                {
                    convertedValues.Add(ConvertSingleRomanNumeralToInt(input[i]));
                }
            }
            convertedValues.Add(ConvertSingleRomanNumeralToInt(input[^1]));
            return convertedValues.Sum();
        }

        private static int ConvertSingleRomanNumeralToInt(char input) => input switch
        {
            'M' => 1000,
            'D' => 500,
            'C' => 100,
            'L' => 50,
            'X' => 10,
            'V' => 5,
            'I' => 1,
            _ => 0
        };


    }
}
