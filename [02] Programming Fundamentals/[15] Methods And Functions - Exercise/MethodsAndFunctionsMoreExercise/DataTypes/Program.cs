using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int integerNumber = int.Parse(Console.ReadLine());

                    int multipliedIntegerNumber = ManipualteDataType(integerNumber);
                    Console.WriteLine(multipliedIntegerNumber);
                    break;

                case "real":
                    double realNumber = double.Parse(Console.ReadLine());

                    double multipliedDoubleNumber = ManipualteDataType(realNumber);
                    Console.WriteLine($"{multipliedDoubleNumber:f2}");
                    break;

                case "string":
                    string inputText = Console.ReadLine();

                    string manipulatedText = ManipualteDataType(inputText);
                    Console.WriteLine(manipulatedText);
                    break;
            }
        }

        static int ManipualteDataType(int number)
        {
            int result = number * 2;

            return result;
        }

        static double ManipualteDataType(double number)
        {
            double result = number * 1.5;

            return result;
        }

        static string ManipualteDataType(string text)
        {
            string result = $"${text}$";

            return result;
        }
    }
}
