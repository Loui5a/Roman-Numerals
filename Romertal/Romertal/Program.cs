namespace Romertal
{
    public class Program
    {
        static void Main()
        {
            /// <summary>
            /// Simple console application asking for user input.
            /// The user chooses whether to convert int to roman numeral or roman numeral to int. 
            /// </summary>

            while (true)
            {
                Console.WriteLine("Please select one:");
                Console.WriteLine("1. Convert a number to roman numeral.");
                Console.WriteLine("2. Convert roman numeral to a number.");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Please enter the number you want converted");
                    int inputValue = Convert.ToInt32(Console.ReadLine());
                    string result = IntToRomanNumeralService.ConvertFromIntToRomanNumerals(inputValue);
                    Console.WriteLine(result);
                }
                else if (input == 2)
                {
                    Console.WriteLine("Please enter the roman numeral you want converted");
                    string inputValue = Console.ReadLine();
                    int convertedValue = RomanNumeralsToIntService.Convert(inputValue);
                    Console.WriteLine(convertedValue);
                }
                Console.WriteLine("Do you want to convert another value? Press N for no and any key for yes.");
                string continueOrNot = Console.ReadLine();
                if (continueOrNot.ToLower() == "n")
                    break;
            }
        }
    }
}
