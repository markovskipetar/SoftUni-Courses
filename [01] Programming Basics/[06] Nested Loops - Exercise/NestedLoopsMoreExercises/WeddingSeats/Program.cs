using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorRows = int.Parse(Console.ReadLine());
            int oddRowSeats = int.Parse(Console.ReadLine());

            int currentSecorRows = firstSectorRows;
            int counter = 0;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                int currentRowSeats = oddRowSeats;

                for (int row = 1; row <= currentSecorRows; row++)
                {
                    for (char seat = 'a'; seat < currentRowSeats + 'a'; seat++)
                    {
                        Console.WriteLine($"{sector}{row}{seat}");
                        counter++;
                    }

                    if (row % 2 == 1)
                    {
                        currentRowSeats += 2;
                    }
                    else
                    {
                        currentRowSeats -= 2;
                    }
                }

                currentSecorRows++;
            }

            Console.WriteLine(counter);
        }
    }
}
