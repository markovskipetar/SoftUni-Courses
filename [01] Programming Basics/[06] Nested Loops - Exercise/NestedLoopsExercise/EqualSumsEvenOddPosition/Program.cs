using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string currentNumber = i.ToString();

                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += int.Parse(currentNumber[j].ToString());
                    }
                    else
                    {
                        oddSum += int.Parse(currentNumber[j].ToString());
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}
