using System;
using System.Globalization;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int currentNumber = i + 1;

                bool isSumOfDigitsDivisibleByEight = IsSumOfDigitsDivisbleByEight(currentNumber);
                bool isContainingAtLeastOneOddDigit = IsContainingAtLeastOneOddDigit(currentNumber);

                if (isSumOfDigitsDivisibleByEight && isContainingAtLeastOneOddDigit)
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }

        static bool IsSumOfDigitsDivisbleByEight(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;

                sum += currentDigit;

                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool IsContainingAtLeastOneOddDigit(int number)
        {
            while (number != 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 == 1)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
