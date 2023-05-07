using System;
using System.Linq;
using System.Security.Cryptography;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbersSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumbersSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            bool areEqual = true;
            int unequaIndex = 0;

            for (int i = 0; i < firstNumbersSequence.Length; i++)
            {
                if (firstNumbersSequence[i] == secondNumbersSequence[i])
                {
                    sum += firstNumbersSequence[i];
                }
                else
                {
                    areEqual = false;
                    unequaIndex = i;
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {unequaIndex} index");
            }
        }
    }
}
