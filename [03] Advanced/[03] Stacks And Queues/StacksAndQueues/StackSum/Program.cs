namespace StackSum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stackNumbers = new Stack<int>(numbers);

            while (true)
            {
                var command = Console.ReadLine().ToLower().Split().ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    stackNumbers.Push(firstNumber);
                    stackNumbers.Push(secondNumber);
                }
                else if (command[0] == "remove")
                {
                    int countToRemove = int.Parse(command[1]);

                    if (stackNumbers.Count >= countToRemove)
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            stackNumbers.Pop();
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Sum: " + stackNumbers.Sum());
        }
    }
}
