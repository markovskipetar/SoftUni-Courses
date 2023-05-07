using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int openingBracketsCount = 0;
            int closingBracketsCount = 0;
            bool areNested = false;

            int nestedCounter = 0;
            string lastBracket = String.Empty;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openingBracketsCount++;

                    if (lastBracket == input && nestedCounter == 0)
                    {
                        nestedCounter++;
                        areNested = true;
                    }

                    lastBracket = "(";
                }
                else if (input == ")")
                {
                    closingBracketsCount++;

                    if (lastBracket == input && nestedCounter == 0)
                    {
                        nestedCounter++;
                        areNested = true;
                    }

                    lastBracket = ")";
                }
            }

            if (openingBracketsCount == closingBracketsCount && !areNested)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
