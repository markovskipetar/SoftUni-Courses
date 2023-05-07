using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < startNumber; i++)
            {
                Console.WriteLine(startNumber - i);
            }
        }
    }
}
