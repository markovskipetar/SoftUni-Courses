using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            bool noEvenOdd = false;
            bool noOddElements = false;

            if (numbersCount == 0)
            {
                noEvenOdd = true;
            }
            else if (numbersCount == 1)
            {
                noOddElements = true;
            }

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            for (int i = 1; i <= numbersCount; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNumber;

                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }

                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                }
                else
                {
                    oddSum += currentNumber;

                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }

                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                }
            }

            if (noEvenOdd)
            {
                Console.WriteLine("OddSum=0.00, ");
                Console.WriteLine("OddMin=No, ");
                Console.WriteLine("OddMax=No, ");
                Console.WriteLine("EvenSum=0.00, ");
                Console.WriteLine("EvenMin=No, ");
                Console.WriteLine("EvenMax=No");
            }
            else if (noOddElements)
            {
                Console.WriteLine($"OddSum={oddSum:f2}, ");
                Console.WriteLine($"OddMin={oddMin:f2}, ");
                Console.WriteLine($"OddMax={oddMax:f2}, ");
                Console.WriteLine("EvenSum=0.00, ");
                Console.WriteLine("EvenMin=No, ");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2}, ");
                Console.WriteLine($"OddMin={oddMin:f2}, ");
                Console.WriteLine($"OddMax={oddMax:f2}, ");
                Console.WriteLine($"EvenSum={evenSum:f2}, ");
                Console.WriteLine($"EvenMin={evenMin:f2}, ");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
