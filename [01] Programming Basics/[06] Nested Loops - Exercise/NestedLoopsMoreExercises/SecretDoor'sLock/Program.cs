using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundrets = int.Parse(Console.ReadLine());
            int dozens = int.Parse(Console.ReadLine());
            int units = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundrets; i++)
            {
                for (int j = 1; j <= dozens; j++)
                {
                    for (int k = 1; k <= units; k++)
                    {
                        if (k % 2 == 0 && i % 2 == 0)
                        {
                            if (j == 2 || j == 3 || j == 5 || j == 7)
                            {
                                Console.WriteLine($"{i} {j} {k}");
                            }
                        }
                    }
                }
            }
        }
    }
}
