namespace RemoveNegativesAndReverse
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber >= 0)
                {
                    result.Add(currentNumber);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine($"empty");
            }
            else
            {
                result.Reverse();

                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
