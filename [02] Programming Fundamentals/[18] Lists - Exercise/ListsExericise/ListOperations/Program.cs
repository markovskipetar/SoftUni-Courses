namespace ListOperations
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
                .Select(x => int.Parse(x))
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "End")
                {
                    break;
                }

                ExecuteCommands(input, command, inputNumbers);
            }

            Console.WriteLine(String.Join(" ", inputNumbers));
        }

        static void ExecuteCommands(string[] input, string command, List<int> inputNumbers)
        {
            switch (command)
            {
                case "Add":
                    {
                        int number = int.Parse(input[1]);

                        AddNumber(inputNumbers, number);
                    }
                    break;

                case "Insert":
                    {
                        int number = int.Parse(input[1]);
                        int index = int.Parse(input[2]);

                        if (0 <= index && index <= inputNumbers.Count - 1)
                        {
                            InsertNumber(inputNumbers, number, index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                    }
                    break;

                case "Remove":
                    {
                        int index = int.Parse(input[1]);

                        if (0 <= index && index <= inputNumbers.Count - 1)
                        {
                            RemoveElement(inputNumbers, index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                    }
                    break;

                case "Shift":
                    {
                        int count = int.Parse(input[2]);

                        string direction = input[1];

                        if (direction == "left")
                        {
                            ShiftLeft(inputNumbers, count);
                        }
                        else
                        {
                            ShiftRight(inputNumbers, count);
                        }
                    }
                    break;
            }
        }

        static void ShiftRight(List<int> inputNumbers, int count)
        {
            for (int i = 0; i < count % inputNumbers.Count; i++)
            {
                int lastElement = inputNumbers[inputNumbers.Count - 1];

                inputNumbers.Insert(0, lastElement);
                inputNumbers.RemoveAt(inputNumbers.Count - 1);
            }
            
        }

        static void ShiftLeft(List<int> inputNumbers, int count)
        {
            for (int i = 0; i < count % inputNumbers.Count; i++)
            {
                int firstNumber = inputNumbers[0];

                inputNumbers.Add(firstNumber);
                inputNumbers.RemoveAt(0);
            }
        }

        static void RemoveElement(List<int> inputNumbers, int index)
        {
            inputNumbers.RemoveAt(index);
        }

        static void InsertNumber(List<int> inputNumbers, int number, int index)
        {
            inputNumbers.Insert(index, number);
        }

        static void AddNumber(List<int> inputNumbers, int number)
        {
            inputNumbers.Add(number);
        }
    }
}
