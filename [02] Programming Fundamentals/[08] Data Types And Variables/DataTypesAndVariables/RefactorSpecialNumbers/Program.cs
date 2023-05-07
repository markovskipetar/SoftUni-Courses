using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers; i++)
            {
                int currentNumber = i + 1;
                int sum = 0;

                while (currentNumber != 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine("{0} -> {1}", i + 1, isSpecial);
            }
        }
    }
}
