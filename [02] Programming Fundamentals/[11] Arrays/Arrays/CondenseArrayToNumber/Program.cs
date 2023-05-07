using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currentRequiredSequence = numbers.Length;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < currentRequiredSequence - 1; j++)
                {
                    numbers[j] = numbers[j] + numbers[j + 1];
                }

                currentRequiredSequence--;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
