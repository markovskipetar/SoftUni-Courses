using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = new int[3];

            FillInputNumbers(inputNumbers);

            int firstNumber = inputNumbers[0];
            int secondNumber = inputNumbers[1];
            int thirdNumber = inputNumbers[2];

            int sumOfFirstTwoNumbers = GetSumOfFirstTwoNumbers(firstNumber, secondNumber);
            int subtractionOfSumAndThirdNumber = SubstractThirdNumberFromSum(sumOfFirstTwoNumbers, thirdNumber);

            Console.WriteLine(subtractionOfSumAndThirdNumber);
        }

        static void FillInputNumbers(int[] inputNumbers)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }
        }

        static int GetSumOfFirstTwoNumbers(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }

        static int SubstractThirdNumberFromSum(int firstTwoNumbersSum, int thirdNumber)
        {
            int subtractions = firstTwoNumbersSum - thirdNumber;

            return subtractions;
        }
    }
}
