namespace ReverseString
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> reversedInput = new Stack<char>(input);

            string result = string.Empty;

            while (reversedInput.Any())
            {
                result += reversedInput.Pop();
            }

            Console.WriteLine(result);
        }
    }
}
