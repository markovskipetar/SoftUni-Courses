using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupOfWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupVolume = int.Parse(Console.ReadLine());

            int waterVolume = 0;
            int buttonPressedCount = 0;


            while (waterVolume < cupVolume)
            {
                string command = Console.ReadLine();

                if (command == "Easy")
                {
                    waterVolume += 50;
                }
                else if (command == "Medium")
                {
                    waterVolume += 100;
                }
                else if (command == "Hard")
                {
                    waterVolume += 200;
                }

                buttonPressedCount++;
            }

            if (waterVolume == cupVolume)
            {
                Console.WriteLine($"The dispenser has been tapped {buttonPressedCount} times.");
            }
            else
            {
                Console.WriteLine($"{waterVolume - cupVolume}ml has been spilled.");
            }
        }
    }
}
