namespace MaximumAndMinimumElement
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int queriesCount = int.Parse(Console.ReadLine());

            var numbers = new Stack<int>();

            var mins = new Stack<int>();
            mins.Push(int.MaxValue);

            var maxes = new Stack<int>();
            maxes.Push(int.MinValue);

            for (int i = 0; i < queriesCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int command = input[0];

                switch (command)
                {
                    case 1:
                        int numberToPush = input[1];
                        numbers.Push(numberToPush);

                        if (numberToPush > maxes.Peek())
                        {
                            maxes.Push(numberToPush);
                        }

                        if (numberToPush < mins.Peek())
                        {
                            mins.Push(numberToPush);
                        }

                        break;

                    case 2:
                        if (numbers.Any())
                        {
                            int topElement = numbers.Pop();

                            if (topElement == mins.Peek())
                            {
                                mins.Pop();
                            }

                            if (topElement == maxes.Peek())
                            {
                                maxes.Pop();
                            }
                        }

                        break;

                    case 3:
                        if (numbers.Any())
                        {
                            Console.WriteLine(maxes.Peek());
                        }

                        break;

                    case 4:
                        if (numbers.Any())
                        {
                            Console.WriteLine(mins.Peek());
                        }

                        break;
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
