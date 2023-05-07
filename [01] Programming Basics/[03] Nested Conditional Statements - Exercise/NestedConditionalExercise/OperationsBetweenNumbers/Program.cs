using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInputNumber = int.Parse(Console.ReadLine());
            int seondInputNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double result = 0.0;
            string evenOrOdd = String.Empty;
            bool isSecondNumZero = false;

            if (operation == '+')
            {
                result = firstInputNumber + seondInputNumber;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
            }
            else if (operation == '-')
            {
                result = firstInputNumber - seondInputNumber;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
            }
            else if (operation == '*')
            {
                result = firstInputNumber * seondInputNumber;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
            }
            else if (operation == '/')
            {
                if (seondInputNumber != 0)
                {
                    result = (double)firstInputNumber / seondInputNumber;
                }
                else
                {
                    isSecondNumZero = true;
                    evenOrOdd = $"Cannot divide {firstInputNumber} by zero";
                }
            }
            else if (operation == '%')
            {
                if (seondInputNumber != 0)
                {
                    result = firstInputNumber % seondInputNumber;
                }
                else
                {
                    isSecondNumZero = true;
                    evenOrOdd = $"Cannot divide {firstInputNumber} by zero";
                }
            }

            if (operation == '+' || operation == '-' || operation == '*')
            {
                Console.WriteLine($"{firstInputNumber} {operation} {seondInputNumber} = {result} - {evenOrOdd}");
            }
            else
            {
                if (isSecondNumZero)
                {
                    Console.WriteLine(evenOrOdd);
                }
                else
                {
                    if (operation == '/')
                    {
                        Console.WriteLine($"{firstInputNumber} {operation} {seondInputNumber} = {result:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstInputNumber} {operation} {seondInputNumber} = {result}");
                    }
                }
            }
        }
    }
}
