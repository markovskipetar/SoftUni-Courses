using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int score = 301;

            bool isRetired = false;
            bool isWon = false;

            int shots = 0;
            int failedShots = 0;

            while (true)
            {
                string sector = Console.ReadLine();

                if (sector == "Retire")
                {
                    isRetired = true;
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                switch (sector)
                {
                    case "Double":
                        points *= 2;
                        break;

                    case "Triple":
                        points *= 3;
                        break;
                }

                if (points <= score)
                {
                    score -= points;
                    shots++;

                    if (score == 0)
                    {
                        isWon = true;
                        break;
                    }
                }
                else
                {
                    failedShots++;
                }
            }

            if (isWon)
            {
                Console.WriteLine($"{playerName} won the leg with {shots} shots.");
            }
            else if (isRetired)
            {
                Console.WriteLine($"{playerName} retired after {failedShots} unsuccessful shots.");
            }
        }
    }
}
