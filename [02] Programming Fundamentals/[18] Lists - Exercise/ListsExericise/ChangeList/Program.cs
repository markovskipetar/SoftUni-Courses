namespace ChangeList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "end")
                {
                    break;
                }

                int number = int.Parse(input[1]);

                if (command == "Delete")
                {
                    DeleteElements(inputNumbers, number);
                }
                else
                {
                    int indexToInsert = int.Parse(input[2]);

                    InsertElement(inputNumbers, indexToInsert, number);
                }
            }

            Console.WriteLine(String.Join(" ", inputNumbers));
        }

        static void InsertElement(List<int> inputNumbers, int indexToInsert, int number)
        {
            inputNumbers.Insert(indexToInsert, number);
        }

        static void DeleteElements(List<int> inputNumbers, int number)
        {
            while (inputNumbers.Contains(number))
            {
                inputNumbers.Remove(number);
            }
        }
    }
}
