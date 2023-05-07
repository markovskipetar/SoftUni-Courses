using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            bool isDone = false;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(currentNumber+ " ");
                    currentNumber++;

                    if (currentNumber > number)
                    {
                        isDone = true;
                        break;
                    }
                }
                Console.WriteLine();

                if (isDone)
                {
                    break;
                }
            }
        }
    }
}
