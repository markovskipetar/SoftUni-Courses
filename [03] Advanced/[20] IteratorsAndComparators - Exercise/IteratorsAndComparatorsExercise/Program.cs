namespace IteratorsAndComparatorsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            ListyIterator<string> listyOperator = new ListyIterator<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = input[0];

                if (command == "END")
                {
                    break;
                }


                switch (command)
                {
                    case "Create":
                        List<string> list = new List<string>();

                        if (input.Length > 1)
                        {
                            for (int i = 1; i < input.Length; i++)
                            {
                                list.Add(input[i]);
                            }

                            listyOperator.AddData(list);
                        }
                        break;

                    case "Move":
                        Console.WriteLine(listyOperator.Move());
                        break;

                    case "HasNext":
                        Console.WriteLine(listyOperator.HasNext());
                        break;

                    case "Print":
                        listyOperator.Print();
                        break;

                    case "PrintAll":
                        foreach (var item in listyOperator)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                }
            }
        }
    }
}
