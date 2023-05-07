using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                bool isIntegerParsingSuccessful = int.TryParse(input, out int intNumber);
                bool isDoubleParsingSuccessful = double.TryParse(input, out double doubleNumber);
                bool isCharacterParsingSuccessfull = char.TryParse(input, out char symbol);
                bool isBooleanParsingSuccessfull = bool.TryParse(input, out bool boolValue);

                if (isIntegerParsingSuccessful)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isDoubleParsingSuccessful)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isCharacterParsingSuccessfull)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBooleanParsingSuccessfull)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
