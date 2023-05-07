using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = 0;
            int biggesCount = 1;

            int currentCount = 1;

            for (int i = 0; i < numbersSequence.Length - 1; i++)
            {
                int currentElement = numbersSequence[i];
                int nextElement = numbersSequence[i + 1];

                if (currentElement == nextElement)
                {
                    currentCount++;

                    if (currentCount > biggesCount)
                    {
                        biggesCount = currentCount;
                        number = currentElement;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            for (int i = 0; i < biggesCount; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
