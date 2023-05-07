using System;

namespace MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = GetPoweredNumber(number, power);

            Console.WriteLine(result);
        }

        static double GetPoweredNumber(double number, int power)
        {
            double poweredNumber = 1;

            for (int i = 0; i < power; i++)
            {
                poweredNumber *= number;
            }

            return poweredNumber;
        }
    }
}
