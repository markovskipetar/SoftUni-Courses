namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            while (true)
            {
                bool areTwoNumbersAdjacent = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    double currentNumber = numbers[i];
                    double nextNumber = numbers[i + 1];

                    if (currentNumber == nextNumber)
                    {
                        numbers[i] *= 2;
                        numbers.RemoveAt(i + 1);

                        areTwoNumbersAdjacent = true;
                    }
                }

                if (!areTwoNumbersAdjacent)
                {
                    break;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
