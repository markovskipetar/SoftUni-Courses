namespace DigitsLettersAndOther
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (char.IsDigit(currentSymbol))
                {
                    digits += currentSymbol;
                }
                else if (char.IsLetter(currentSymbol))
                {
                    letters += currentSymbol;
                }
                else
                {
                    others += currentSymbol;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
