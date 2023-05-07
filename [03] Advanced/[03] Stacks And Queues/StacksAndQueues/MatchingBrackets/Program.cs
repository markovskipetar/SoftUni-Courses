namespace MatchingBrackets
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var openingBracketIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == '(')
                {
                    openingBracketIndexes.Push(i);
                }
                else if (symbol == ')')
                {
                    int lastOpeningBracketIndex = openingBracketIndexes.Pop();
                    int currentClosingBracketIndex = i;
                    int length = currentClosingBracketIndex - lastOpeningBracketIndex + 1;

                    string subExpression = input.Substring(lastOpeningBracketIndex, length);
                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}
