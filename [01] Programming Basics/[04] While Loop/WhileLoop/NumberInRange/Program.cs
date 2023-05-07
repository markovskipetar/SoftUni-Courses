using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            while (!(1 <= inputNumber && inputNumber <= 100))
            {
                Console.WriteLine("Invalid number!");

                inputNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", inputNumber);
        }
    }
}
