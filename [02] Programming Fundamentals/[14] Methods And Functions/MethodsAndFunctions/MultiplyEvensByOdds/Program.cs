using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = Math.Abs(number);

            int oddDigitsSum = GetSumOfOddDigits(number);
            int eventDigitsSum = GetSumOfEvenDigits(number);

            Console.WriteLine(GetMultiplicationOfEvenAndOdd(eventDigitsSum, oddDigitsSum));
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenDigitsSum = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 == 0)
                {
                    evenDigitsSum += currentDigit;
                }

                number /= 10;
            }

            return evenDigitsSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddDigitsSum = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 == 1)
                {
                    oddDigitsSum += currentDigit;
                }

                number /= 10;
            }

            return oddDigitsSum;
        }

        static int GetMultiplicationOfEvenAndOdd(int eventDigitsSum, int oddDigitsSum)
        {
            int result = eventDigitsSum * oddDigitsSum;

            return result;
        }
    }
}
