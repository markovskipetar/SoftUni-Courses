namespace BalancedParentheses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var openingBrackets = new Stack<char>();
            string output = "YES";

            foreach (var symbol in input)
            {
                bool isBalanced = true;

                if (symbol == '(' || symbol == '[' || symbol == '{')
                {
                    openingBrackets.Push(symbol);
                }
                else
                {
                    if (!openingBrackets.Any())
                    {
                        isBalanced = false;
                        output = "NO";
                        break;
                    }

                    char lastOpeningBracket = openingBrackets.Pop();

                    switch (symbol)
                    {
                        case ')':
                            if (lastOpeningBracket != '(')
                            {
                                isBalanced = false;
                            }
                            break;


                        case ']':
                            if (lastOpeningBracket != '[')
                            {
                                isBalanced = false;
                            }
                            break;

                        case '}':
                            if (lastOpeningBracket != '{')
                            {
                                isBalanced = false;
                            }
                            break;
                    }
                }

                if (!isBalanced)
                {
                    output = "NO";
                    break;
                }
            }

            if (openingBrackets.Any())
            {
                output = "NO";
            }

            Console.WriteLine(output);
        }
    }
}
