using System;
using System.Runtime.InteropServices;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pairsCount; i++)
            {
                string currentPair = Console.ReadLine();

                string firstNumber = String.Empty;
                string secondNumber = String.Empty;

                bool isSpaceFound = false;

                for (int j = 0; j < currentPair.Length; j++)
                {
                    char currentSymbol = currentPair[j];

                    if (currentSymbol == ' ')
                    {
                        isSpaceFound = true;
                    }
                    else
                    {
                        if (!isSpaceFound)
                        {
                            firstNumber += currentSymbol;
                        }
                        else
                        {
                            secondNumber += currentSymbol;
                        }
                    }
                }

                long firstNumberInteger = long.Parse(firstNumber);
                long secondNumberInteger = long.Parse(secondNumber);

                long sum = 0;

                if (firstNumberInteger > secondNumberInteger)
                {
                    while (firstNumberInteger != 0)
                    {
                        sum += firstNumberInteger % 10;
                        firstNumberInteger /= 10;
                    }
                }
                else
                {
                    while (secondNumberInteger != 0)
                    {
                        sum += secondNumberInteger % 10;
                        secondNumberInteger /= 10;
                    }
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
