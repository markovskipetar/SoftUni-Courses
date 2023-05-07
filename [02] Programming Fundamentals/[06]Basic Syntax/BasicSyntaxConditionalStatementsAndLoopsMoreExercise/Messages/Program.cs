using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitsCount = int.Parse(Console.ReadLine());

            string message = String.Empty;

            for (int i = 0; i < digitsCount; i++)
            {
                string input = Console.ReadLine();
                int inputLength = input.Length;

                char currentSymbol = ' ';

                switch (input[0])
                {
                    case '2':
                        currentSymbol = 'a';
                        break;

                    case '3':
                        currentSymbol = 'd';
                        break;

                    case '4':
                        currentSymbol = 'g';
                        break;

                    case '5':
                        currentSymbol = 'j';
                        break;

                    case '6':
                        currentSymbol = 'm';
                        break;

                    case '7':
                        currentSymbol = 'p';
                        break;

                    case '8':
                        currentSymbol = 't';
                        break;

                    case '9':
                        currentSymbol = 'w';
                        break;

                    case '0':
                        currentSymbol = ' ';
                        break;
                }

                int currentSymbolNumber = currentSymbol;
                currentSymbolNumber += inputLength - 1;

                currentSymbol = (char)currentSymbolNumber;
                message += currentSymbol;
            }

            Console.WriteLine(message);
        }
    }
}
