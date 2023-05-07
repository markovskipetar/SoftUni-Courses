namespace SimpleCalculator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Reverse().ToArray();

            var stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                int tempSum = operation switch
                {
                    "+" => firstNumber + secondNumber,
                    "-" => firstNumber - secondNumber,
                    _ => 0
                };

                stack.Push(tempSum.ToString());
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
