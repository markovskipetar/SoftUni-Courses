using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());

            rotationsCount = rotationsCount % numbersSequence.Length;

            for (int i = 0; i < rotationsCount; i++)
            {
                int firstNumber = numbersSequence[0];

                for (int j = 0; j < numbersSequence.Length - 1; j++)
                {
                    numbersSequence[j] = numbersSequence[j + 1];
                }

                numbersSequence[numbersSequence.Length - 1] = firstNumber;
            }

            Console.WriteLine(String.Join(" ", numbersSequence));
        }
    }
}
