using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = numbersSequence.Sum();

            bool isEqualSumReached = false;

            for (int i = 0; i < numbersSequence.Length; i++)
            {
                int currentElement = numbersSequence[i];

                rightSum -= currentElement;

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqualSumReached = true;
                    break;
                }
                else
                {
                    leftSum += currentElement;
                }
            }

            if (!isEqualSumReached)
            {
                Console.WriteLine("no");
            }
        }
    }
}
