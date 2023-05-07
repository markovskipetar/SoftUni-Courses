namespace AppendArrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            List<string> input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                string currentText = input[i];

                int[] currentNumbers = currentText
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                numbers.AddRange(currentNumbers);
            }


            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
