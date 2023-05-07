using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int counter = 0;

            int minValue = int.MaxValue;

            while (counter < numbersCount)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < minValue)
                {
                    minValue = currentNumber;
                }

                counter++;
            }

            Console.WriteLine(minValue);
        }
    }
}
