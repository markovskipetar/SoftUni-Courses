using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            foreach (int currentNumber in numbers)
            {
                if (currentNumber % 2 == 0)
                {
                    evenNumbersSum += currentNumber;
                }
                else
                {
                    oddNumbersSum += currentNumber;
                }
            }

            int result = evenNumbersSum - oddNumbersSum;

            Console.WriteLine(result);
        }
    }
}
