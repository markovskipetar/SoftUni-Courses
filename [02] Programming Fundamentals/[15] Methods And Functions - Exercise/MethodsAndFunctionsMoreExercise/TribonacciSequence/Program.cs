using System;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] tribonacciNumbers = new int[number];

            tribonacciNumbers[0] = 1;

            for (int i = 1; i < tribonacciNumbers.Length; i++)
            {
                if (i < 3)
                {
                    tribonacciNumbers[i] = GetCurrentTribonacciNumber(tribonacciNumbers, 0, i);
                }
                else
                {
                    tribonacciNumbers[i] = GetCurrentTribonacciNumber(tribonacciNumbers, i - 3, i);
                }
            }

            Console.WriteLine(String.Join(" ", tribonacciNumbers));
        }

        static int GetCurrentTribonacciNumber(int[] tribonacciNumbers, int start, int end)
        {
            int currentTribonacciNumber = 0;

            for (int i = start; i < end; i++)
            {
                currentTribonacciNumber += tribonacciNumbers[i];
            }

            return currentTribonacciNumber;
        }
    }
}
