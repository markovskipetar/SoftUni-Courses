using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenNumbersSum = 0;

            foreach (int currentNumber in numbers)
            {
                if (currentNumber % 2 == 0)
                {
                    evenNumbersSum += currentNumber;
                }
            }

            Console.WriteLine(evenNumbersSum);
        }
    }
}
