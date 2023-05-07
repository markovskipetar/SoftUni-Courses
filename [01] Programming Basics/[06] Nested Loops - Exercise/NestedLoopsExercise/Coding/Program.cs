using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberText = number.ToString();

            for (int i = numberText.Length - 1; i >= 0; i--)
            {
                char currentSymbol = numberText[i];
                int currentNumber = int.Parse(numberText[i].ToString());

                if (currentSymbol == '0')
                {
                    Console.Write("ZERO");
                }
                else
                {
                    int numberASCII = currentNumber + 33;

                    for (int j = 0; j < currentNumber; j++)
                    {
                        Console.Write((char)numberASCII);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
