namespace ValidUsernames
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];

                bool isLengthValid = (3 < currentWord.Length && currentWord.Length < 16);
                bool areSymbolsValid = true;

                for (int j = 0; j < currentWord.Length; j++)
                {
                    char currentSymbol = currentWord[j];

                    if (!char.IsLetterOrDigit(currentSymbol) && currentSymbol != '-' && currentSymbol != '_')
                    {
                        areSymbolsValid = false;
                        break;
                    }
                }

                if (isLengthValid && areSymbolsValid)
                {
                    Console.WriteLine(currentWord);
                }
            }
        }
    }
}
