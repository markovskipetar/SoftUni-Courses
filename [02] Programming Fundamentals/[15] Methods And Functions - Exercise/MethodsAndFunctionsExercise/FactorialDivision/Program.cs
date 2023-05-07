using System;
using System.ComponentModel;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstNumberFactorial = GetFactorial(firstNumber);
            double secondNumberFactorial = GetFactorial(secondNumber);

            double result = firstNumberFactorial / secondNumberFactorial;

            Console.WriteLine($"{result:F2}");
        }

        static double GetFactorial (int firstNumber)
        {
            double result = 1;

            for (int i = 0; i < firstNumber; i++)
            {
                int multiplier = i + 1;

                result *= multiplier;
            }

            return result;
        }
    }
}
