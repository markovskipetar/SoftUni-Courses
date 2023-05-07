using System;
using System.Runtime.ConstrainedExecution;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string dataType = Console.ReadLine();

            if (dataType == "string")
            {
                string firstText = Console.ReadLine();
                string secondText = Console.ReadLine();

                string result = GetGreaterString(firstText, secondText);

                Console.WriteLine(result);
            }
            else if (dataType == "char")
            {
                char firstSymbol = char.Parse(Console.ReadLine());
                char secondSymbol = char.Parse(Console.ReadLine());

                char result = GetGreaterChar(firstSymbol, secondSymbol);

                Console.WriteLine(result);
            }
            else if (dataType == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int result = GetGreaterInteger(firstNumber, secondNumber);

                Console.WriteLine(result);
            }
        }

        static string GetGreaterString(string firstText, string secondText)
        {
            int value = String.Compare(firstText, secondText);

            if (value < 0)
            {
                return secondText;
            }
            else
            {
                return firstText;
            }
        }

        static char GetGreaterChar(char firstSymbol, char secondSymbol)
        {
            if (firstSymbol > secondSymbol)
            {
                return firstSymbol;
            }
            else
            {
                return secondSymbol;
            }
        }

        static int GetGreaterInteger(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
