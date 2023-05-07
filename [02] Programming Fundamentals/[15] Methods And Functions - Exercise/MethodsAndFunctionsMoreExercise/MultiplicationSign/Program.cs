using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = new int[3];

            ReadInputNumbers(inputNumbers);

            int negativeElementsCount = GetCountOfNegativeElements(inputNumbers);

            PrintMultiplicationSign(negativeElementsCount);
        }

        static int GetCountOfNegativeElements(int[] inputNumbers)
        {
            int negativeElementsCount = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int currentNumber = inputNumbers[i];

                if (currentNumber == 0)
                {
                    return -1;
                }
                else if (currentNumber < 0)
                {
                    negativeElementsCount++;
                }
            }

            return negativeElementsCount;
        }

        static void ReadInputNumbers(int[] inputNumbers)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PrintMultiplicationSign(int negativeElementsCount)
        {
            if (negativeElementsCount == -1)
            {
                Console.WriteLine("zero");
            }
            else if (negativeElementsCount % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
