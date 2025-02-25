namespace Romertal
{
    public class IntToRomanNumeralService
    {
        /// <summary>
        ///  ConvertFromIntToRomanNumerals is the main method. 
        ///  The input is first converted into an array of ones, tens, hundreds and thousands [1000,100,10,1] using ConvertInputToArray and saved into intArray.
        ///  The code iterates through intArray calling Distribution to figure aout whether to call ConvertOnes, ConvertTens, ConvertHundreds or ConvertThousands.
        ///  ConvertFromIntToRomanNumerals returns a string with the roman numeral equivalent to the input.
        /// </summary>
        public static string ConvertFromIntToRomanNumerals(int input)
        {
            int[] intArray = ConvertInputToArray(input);
            List<string> romanNumerals = [];
            for (int i = 0; i < intArray.Length; i++)
            {
                romanNumerals.Add(Distribution(intArray[i]));
            }
            return String.Concat(romanNumerals);
        }
        public static int[] ConvertInputToArray(int input)
        {
            int placeholder = input;
            int counter = 0;
            while (placeholder > 0)
            {
                placeholder /= 10;
                counter++;
            }
            int[] inputArray = new int[counter];
            int multiplier = 1;
            for (int i = counter - 1; i >= 0; i--)
            {
                inputArray[i] = (input % (multiplier * 10) / multiplier) * multiplier;
                multiplier *= 10;
            }
            return inputArray;
        }
        public static string Distribution(int input)
        {

            if (input / 10 == 0)
                return ConvertOnes(input);
            else if ((input / 10) / 10 == 0)
                return ConvertTens(input);
            else if (((input / 10) / 10) / 10 == 0)
                return ConvertHundreds(input);
            else
                return ConvertThousands(input);
        }

        private static string ConvertOnes(int input) => input switch
        {
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            0 => "",
            _ => throw new Exception("Invalid input")
        };


        public static string ConvertTens(int input) => input switch
        {
            10 => "X",
            20 => "XX",
            30 => "XXX",
            40 => "XL",
            50 => "L",
            60 => "LX",
            70 => "LXX",
            80 => "LXXX",
            90 => "XC",
            0 => "",
            _ => throw new Exception("Invalid input")
        };

        public static string ConvertHundreds(int input) => input switch
        {
            100 => "C",
            200 => "CC",
            300 => "CCC",
            400 => "CD",
            500 => "D",
            600 => "DC",
            700 => "DCC",
            800 => "DCCC",
            900 => "CM",
            0 => "",
            _ => throw new Exception("Invalid input")
        };

        public static string ConvertThousands(int input) => input switch
        {
            1000 => "M",
            2000 => "MM",
            3000 => "MMM",
            _ => throw new Exception("Invalid input")
        };
    }
}
