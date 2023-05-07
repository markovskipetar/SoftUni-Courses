using System;
using System.Runtime.ConstrainedExecution;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            switch (command)
            {
                case "add":
                    sum = Add(firstNumber, secondNumber);
                    break;

                case "multiply":
                    sum = Multiply(firstNumber, secondNumber);
                    break;

                case "subtract":
                    sum = Subtract(firstNumber, secondNumber);
                    break;

                case "divide":
                    sum = Divide(firstNumber, secondNumber);
                    break;
            }

            Console.WriteLine(sum);
        }
        static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }
        static int Multiply(int firstNumber, int secondNumber)
        {
            int sum = firstNumber * secondNumber;

            return sum;
        }
        static int Subtract(int firstNumber, int secondNumber)
        {
            int sum = firstNumber - secondNumber;

            return sum;
        }
        static int Divide(int firstNumber, int secondNumber)
        {
            int sum = firstNumber / secondNumber;

            return sum;
        }
    }
}
