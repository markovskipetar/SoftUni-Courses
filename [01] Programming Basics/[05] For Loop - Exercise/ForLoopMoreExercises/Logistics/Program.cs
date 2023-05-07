using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadsCount = int.Parse(Console.ReadLine());

            double microbus = 0;
            double lorry = 0;
            double train = 0;

            for (int i = 0; i < loadsCount; i++)
            {
                int currentLoadWight = int.Parse(Console.ReadLine());

                if (currentLoadWight <= 3)
                {
                    microbus += currentLoadWight;
                }
                else if (4 <= currentLoadWight && currentLoadWight <= 11)
                {
                    lorry += currentLoadWight;
                }
                else
                {
                    train += currentLoadWight;
                }
            }

            double allLoads = microbus + lorry + train;

            double averagePrice = ((microbus * 200) + (lorry * 175) + (train * 120)) / allLoads;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{microbus / allLoads * 100:f2}%");
            Console.WriteLine($"{lorry / allLoads * 100:f2}%");
            Console.WriteLine($"{train / allLoads * 100:f2}%");
        }
    }
}
