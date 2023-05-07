using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fansCount = int.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < fansCount; i++)
            {
                string currentFanSector = Console.ReadLine();

                switch (currentFanSector)
                {
                    case "A":
                        sectorA++;
                        break;

                    case "B":
                        sectorB++;
                        break;

                    case "V":
                        sectorV++;
                        break;

                    case "G":
                        sectorG++;
                        break;
                }
            }

            double allFans = sectorA + sectorB + sectorG + sectorV;

            Console.WriteLine($"{sectorA / fansCount * 100:f2}%");
            Console.WriteLine($"{sectorB / fansCount * 100:f2}%");
            Console.WriteLine($"{sectorV / fansCount * 100:f2}%");
            Console.WriteLine($"{sectorG / fansCount * 100:f2}%");
            Console.WriteLine($"{allFans / stadiumCapacity * 100:f2}%");
        }
    }
}
