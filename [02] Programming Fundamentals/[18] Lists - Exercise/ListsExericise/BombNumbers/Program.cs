namespace BombNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(x => int.Parse(x))
                 .ToList();

            int[] input = Console.ReadLine()
                 .Split()
                 .Select(x => int.Parse(x))
                 .ToArray();

            int specialNumber = input[0];
            int power = input[1];

            while (numbers.Contains(specialNumber))
            {
                int specialNumberIndex = numbers.IndexOf(specialNumber);

                specialNumberIndex = DetonateLeftPart(numbers, specialNumberIndex, power);

                DetonateRightPart(numbers, specialNumberIndex, power);
            }

            Console.WriteLine(numbers.Sum());
        }
        static int DetonateLeftPart(List<int> numbers, int index, int power)
        {
            int numbersToLeftBorderCount = index;

            for (int i = 0; i < Math.Min(numbersToLeftBorderCount, power); i++)
            {
                numbers.RemoveAt(index - 1);
                index--;
            }

            return index;
        }

        static void DetonateRightPart(List<int> numbers, int index, int power)
        {
            int numbersToRightBorderCount = numbers.Count - (index + 1);

            for (int i = 0; i < Math.Min(numbersToRightBorderCount, power); i++)
            {
                numbers.RemoveAt(index + 1);
            }

            numbers.RemoveAt(index);
        }
    }
}
