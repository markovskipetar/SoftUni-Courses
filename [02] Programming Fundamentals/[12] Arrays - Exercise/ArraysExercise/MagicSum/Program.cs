using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersSequence.Length; i++)
            {
                int firstElement = numbersSequence[i];

                for (int j = i + 1; j < numbersSequence.Length; j++)
                {
                    int secondElement = numbersSequence[j];

                    if (firstElement + secondElement == magicSum)
                    {
                        Console.WriteLine($"{firstElement} {secondElement}");
                    }
                }
            }
        }
    }
}
