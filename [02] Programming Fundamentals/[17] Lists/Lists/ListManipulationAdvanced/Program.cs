namespace ListManipulationAdvanced
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool printNumbers = ExecuteCommands(numbers);

            if (printNumbers)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static bool ExecuteCommands(List<int> numbers)
        {
            bool printNumbers = false;

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
                        printNumbers = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(input[1]);
                        numbers.Remove(numberToRemove);
                        printNumbers = true;
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(input[1]);
                        numbers.RemoveAt(indexToRemove);
                        printNumbers = true;
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(input[1]);
                        int indexToInsert = int.Parse(input[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        printNumbers = true;
                        break;

                    case "Contains":
                        int numberToCheck = int.Parse(input[1]);
                        if (numbers.Contains(numberToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        List<int> evenNumber = new List<int>();
                        foreach (var number in numbers)
                        {
                            if (number % 2 == 0)
                            {
                                evenNumber.Add(number);
                            }
                        }
                        Console.WriteLine(String.Join(" ", evenNumber));
                        break;

                    case "PrintOdd":
                        List<int> oddNumber = new List<int>();
                        foreach (var number in numbers)
                        {
                            if (number % 2 == 1)
                            {
                                oddNumber.Add(number);
                            }
                        }
                        Console.WriteLine(String.Join(" ", oddNumber));
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "Filter":
                        string comparisonOperator = input[1];
                        int comparisonNumber = int.Parse(input[2]);

                        string result = String.Empty;

                        switch (comparisonOperator)
                        {
                            case ">":
                                result = BiggerNumbers(comparisonNumber, numbers);
                                break;

                            case ">=":
                                result = BiggerOrEqualNumbers(comparisonNumber, numbers);
                                break;

                            case "<":
                                result = SmallerNumbers(comparisonNumber, numbers);
                                break;

                            case "<=":
                                result = SmallerOrEqualNumbers(comparisonNumber, numbers);
                                break;

                        }

                        Console.WriteLine(result);
                        break;
                }
            }

            return printNumbers;
        }

        static string SmallerOrEqualNumbers(int comparisonNumber, List<int> numbers)
        {
            List<int> resultNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number <= comparisonNumber)
                {
                    resultNumbers.Add(number);
                }
            }

            return String.Join(" ", resultNumbers);
        }

        static string SmallerNumbers(int comparisonNumber, List<int> numbers)
        {
            List<int> resultNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number < comparisonNumber)
                {
                    resultNumbers.Add(number);
                }
            }

            return String.Join(" ", resultNumbers);
        }

        static string BiggerOrEqualNumbers(int comparisonNumber, List<int> numbers)
        {
            List<int> resultNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number >= comparisonNumber)
                {
                    resultNumbers.Add(number);
                }
            }

            return String.Join(" ", resultNumbers);
        }

        static string BiggerNumbers(int comparisonNumber, List<int> numbers)
        {
            List<int> resultNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number > comparisonNumber)
                {
                    resultNumbers.Add(number);
                }
            }

            return String.Join(" ", resultNumbers);
        }
    }
}
