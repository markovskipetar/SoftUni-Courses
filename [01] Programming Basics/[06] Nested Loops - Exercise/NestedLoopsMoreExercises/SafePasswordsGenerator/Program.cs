using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int passwordsMaxCount = int.Parse(Console.ReadLine());

            int A = 35;
            int B = 64;

            int counter = 0;

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A}|");
                    counter++;

                    if (A == 55)
                    {
                        A = 35;
                    }
                    else
                    {
                        A++;
                    }

                    if (B == 96)
                    {
                        B = 64;
                    }
                    else
                    {
                        B++;
                    }

                    if (counter == passwordsMaxCount)
                    {
                        break;
                    }
                }

                if (counter == passwordsMaxCount)
                {
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}
