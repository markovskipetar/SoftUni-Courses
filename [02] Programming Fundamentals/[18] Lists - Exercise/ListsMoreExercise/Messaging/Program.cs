namespace Messaging
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            string text = Console.ReadLine();

            List<char> textSymbols = new List<char>(text);

            string message = String.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                int currentNumberSumOfDigits = GetSumOfDigits(currentNumber);

                char symbol = GetSymbol(textSymbols, currentNumberSumOfDigits);

                message += symbol;
            }

            Console.WriteLine(message);
        }

        static char GetSymbol(List<char> textSymbols, int index)
        {
            char symbol = ' ';

            int numberOfSymbols = textSymbols.Count;

            if (index >= numberOfSymbols)
            {
                index -= numberOfSymbols;
            }

            symbol = textSymbols[index];

            textSymbols.RemoveAt(index);

            return symbol;
        }

        static int GetSumOfDigits(int currentNumber)
        {
            int sum = 0;

            while (currentNumber != 0)
            {
                sum += currentNumber % 10;

                currentNumber /= 10;
            }

            return sum;
        }
    }
}
