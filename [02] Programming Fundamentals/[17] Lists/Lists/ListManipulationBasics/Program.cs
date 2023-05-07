namespace ListManipulationBasics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            ExecuteCommands(numbers);

            Console.WriteLine(String.Join(" ", numbers));
        }

        static void ExecuteCommands(List<int> numbers)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(input[1]);
                        numbers.Add(numberToAdd);
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(input[1]);
                        numbers.Remove(numberToRemove);
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(input[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(input[1]);
                        int indexToInsert = int.Parse(input[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }
        }
    }
}
