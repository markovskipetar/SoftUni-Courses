using System;
using System.Runtime.ConstrainedExecution;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            string operatorAsText = Console.ReadLine();
            double secondNumber = int.Parse(Console.ReadLine());

            double sum = 0;

            switch (operatorAsText)
            {
                case "+":
                    sum = Add(firstNumber, secondNumber);
                    break;

                case "*":
                    sum = Multiply(firstNumber, secondNumber);
                    break;

                case "-":
                    sum = Subtract(firstNumber, secondNumber);
                    break;

                case "/":
                    sum = Divide(firstNumber, secondNumber);
                    break;
            }

            Console.WriteLine(sum);
        }

        static double Add(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;

            return sum;
        }
        static double Multiply(double firstNumber, double secondNumber)
        {
            double sum = firstNumber * secondNumber;

            return sum;
        }
        static double Subtract(double firstNumber, double secondNumber)
        {
            double sum = firstNumber - secondNumber;

            return sum;
        }
        static double Divide(double firstNumber, double secondNumber)
        {
            double sum = firstNumber / secondNumber;

            return sum;
        }
    }
}
