using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1ToNWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i += 3)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
