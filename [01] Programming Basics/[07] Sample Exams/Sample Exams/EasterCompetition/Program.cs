using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());

            string topBaker = String.Empty;
            int topBakerScore = 0;

            for (int i = 0; i < easterBreads; i++)
            {
                string currentBaker = Console.ReadLine();
                int currentBakerScore = 0;

                while (true)
                {
                    string points = Console.ReadLine();

                    if (points == "Stop")
                    {
                        break;
                    }

                    currentBakerScore += int.Parse(points);
                }

                Console.WriteLine($"{currentBaker} has {currentBakerScore} points.");

                if (currentBakerScore > topBakerScore)
                {
                    Console.WriteLine($"{currentBaker} is the new number 1!");

                    topBaker = currentBaker;
                    topBakerScore = currentBakerScore;
                }
            }

            Console.WriteLine($"{topBaker} won competition with {topBakerScore} points!");
        }
    }
}
