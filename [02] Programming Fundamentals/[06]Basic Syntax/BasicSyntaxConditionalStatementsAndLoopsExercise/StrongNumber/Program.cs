using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int tempNumber = number;
            int factorialsSum = 0;

            while (tempNumber != 0)
            {
                int currentDigit = tempNumber % 10;
                int tempFactorial = 1;

                for (int i = 1; i <= currentDigit; i++)
                {
                    tempFactorial *= i;
                }

                tempNumber /= 10;
                factorialsSum += tempFactorial;
            }

            if (factorialsSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
