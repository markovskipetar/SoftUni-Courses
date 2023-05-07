using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;

            int maxEggs = 0;
            string maxEggsColor = String.Empty;

            for (int i = 0; i < eggs; i++)
            {
                string currentEggColor = Console.ReadLine();

                if (currentEggColor == "red")
                {
                    redEggs++;

                    if (redEggs > maxEggs)
                    {
                        maxEggs = redEggs;
                        maxEggsColor = "red";
                    }
                }
                else if (currentEggColor == "orange")
                {
                    orangeEggs++;

                    if (orangeEggs > maxEggs)
                    {
                        maxEggs = orangeEggs;
                        maxEggsColor = "orange";
                    }
                }
                else if (currentEggColor == "blue")
                {
                    blueEggs++;

                    if (blueEggs > maxEggs)
                    {
                        maxEggs = blueEggs;
                        maxEggsColor = "blue";
                    }
                }
                else if (currentEggColor == "green")
                {
                    greenEggs++;

                    if (greenEggs > maxEggs)
                    {
                        maxEggs = greenEggs;
                        maxEggsColor = "green";
                    }
                }
            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxEggsColor}");
        }
    }
}
