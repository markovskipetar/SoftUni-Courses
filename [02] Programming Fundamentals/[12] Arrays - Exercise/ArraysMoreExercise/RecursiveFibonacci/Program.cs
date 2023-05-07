using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] fibonacciNumber = new int[number];

            for (int i = 0; i < number; i++)
            {
                if (i < 2)
                {
                    fibonacciNumber[i] = 1;
                }
                else
                {
                    fibonacciNumber[i] = fibonacciNumber[i - 1] + fibonacciNumber[i - 2];
                }
            }

            Console.WriteLine(fibonacciNumber[number - 1]);
        }
    }
}
