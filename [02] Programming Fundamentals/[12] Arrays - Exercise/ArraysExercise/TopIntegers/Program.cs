using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbersSequence.Length - 1; i++)
            {
                int currentNumber = numbersSequence[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < numbersSequence.Length; j++)
                {
                    int currentComparingNumber = numbersSequence[j];

                    if (!(currentNumber > currentComparingNumber))
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currentNumber + " ");
                }
            }

            Console.WriteLine(numbersSequence[numbersSequence.Length - 1]);
        }
    }
}
