using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string currentWord = String.Empty;
            string finalWord = String.Empty;

            int usedC = 0;
            int usedO = 0;
            int usedN = 0;

            while (input != "End")
            {
                if (input == "c")
                {
                    if (usedC >= 1)
                    {
                        currentWord += input;
                    }
                    else
                    {
                        usedC++;
                    }
                }
                else if (input == "o")
                {
                    if (usedO >= 1)
                    {
                        currentWord += input;
                    }
                    else
                    {
                        usedO++;
                    }
                }
                else if (input == "n")
                {
                    if (usedN >= 1)
                    {
                        currentWord += input;
                    }
                    else
                    {
                        usedN++;
                    }
                }
                else
                {
                    char currentSymbol = input[0];

                    if ((currentSymbol >= 'a' && currentSymbol <= 'z') || (currentSymbol >= 'A' && currentSymbol <= 'Z'))
                    {
                        currentWord += input;
                    }
                }

                if (usedC >= 1 && usedO >= 1 && usedN >= 1)
                {
                    currentWord += " ";
                    finalWord += currentWord;

                    usedC = 0;
                    usedO = 0;
                    usedN = 0;

                    currentWord = String.Empty;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(finalWord);
        }
    }
}
