namespace GaussTrick
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int listCount = numbers.Count;

            for (int i = 0; i < listCount / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];

                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
