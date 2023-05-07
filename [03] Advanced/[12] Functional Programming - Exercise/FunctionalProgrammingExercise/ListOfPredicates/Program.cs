namespace ListOfPredicates
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            int leftBound = 1;
            int rightBound = int.Parse(Console.ReadLine());
            int[] dividersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int[], bool> isDivisible = new Func<int, int[], bool>((num, dividers) =>
            {
                foreach (var divider in dividers)
                {
                    if (num % divider != 0)
                    {
                        return false;
                    }
                }

                return true;
            });

            List<int> resultNumbers = new List<int>();

            for (int i = leftBound; i <= rightBound; i++)
            {
                int number = i;

                if (isDivisible(number, dividersInput))
                {
                    resultNumbers.Add(number);
                }
            }

            Console.WriteLine(String.Join(" ", resultNumbers));
        }
    }
}
