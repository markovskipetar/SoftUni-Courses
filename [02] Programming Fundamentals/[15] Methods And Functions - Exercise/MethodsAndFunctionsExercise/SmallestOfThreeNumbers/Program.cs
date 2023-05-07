using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                smallestNumber = GetSmallerNumber(currentNumber, smallestNumber);
            }

            Console.WriteLine(smallestNumber);
        }

        static int GetSmallerNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                return firstNumber;
            }

            return secondNumber;
        }
    }
}
