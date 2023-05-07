using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] newNumbers = new int[inputNumbers.Length / 2];

            int startLeftIndex = inputNumbers.Length / 4 - 1;
            int startRightIndex = inputNumbers.Length / 4;

            for (int i = 0; i < inputNumbers.Length / 4; i++)
            {
                int leftElement = inputNumbers[i];
                int rightElement = inputNumbers[inputNumbers.Length - i - 1];

                newNumbers[startLeftIndex] = leftElement;
                newNumbers[startRightIndex] = rightElement;

                startLeftIndex--;
                startRightIndex++;
            }

            int inputNumbersStartIndex = inputNumbers.Length / 4;

            for (int i = 0; i < newNumbers.Length; i++)
            {
                newNumbers[i] += inputNumbers[inputNumbersStartIndex + i];
            }

            Console.WriteLine(String.Join(" ", newNumbers));
        }
    }
}
