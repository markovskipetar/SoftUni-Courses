using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tablesAvailable = int.Parse(Console.ReadLine());

            int tablesUsed = 0;

            for (int i = 0; i < men; i++)
            {
                for (int j = 0; j < women; j++)
                {
                    int currentMan = i + 1;
                    int currentWoman = j + 1;

                    if (tablesUsed == tablesAvailable)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"({currentMan} <-> {currentWoman}) ");
                        tablesUsed++;
                    }
                }
            }
        }
    }
}