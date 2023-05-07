using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());

            int[] firstSequence = new int[pairsCount];
            int[] secondSequence = new int[pairsCount];

            for (int i = 0; i < pairsCount; i++)
            {
                int[] currentSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int leftNumber = currentSequence[0];
                int rightNumber = currentSequence[1];

                if (i % 2 == 0)
                {
                    firstSequence[i] = leftNumber;
                    secondSequence[i] = rightNumber;
                }
                else
                {
                    firstSequence[i] = rightNumber;
                    secondSequence[i] = leftNumber;
                }
            }

            Console.WriteLine(String.Join(" ", firstSequence));
            Console.WriteLine(String.Join(" ", secondSequence));
        }
    }
}
