using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesOfDetergent = int.Parse(Console.ReadLine());
            int DetergentInML = 750 * bottlesOfDetergent;

            string command = Console.ReadLine();
            int counter = 1;

            int dishesWashed = 0; 
            int potsWashed = 0; 
            int requiredDetergent = 0;

            bool isDetergentOver = false;

            while (command != "End")
            {
                if (counter % 3 == 0)
                {
                    requiredDetergent = 15 * int.Parse(command);

                    if (requiredDetergent <= DetergentInML)
                    {
                        potsWashed += int.Parse(command);
                        DetergentInML -= requiredDetergent;
                    }
                    else
                    {
                        isDetergentOver = true;
                        break;
                    }

                }
                else
                {
                    requiredDetergent = 5 * int.Parse(command);

                    if (requiredDetergent <= DetergentInML)
                    {
                        dishesWashed += int.Parse(command);
                        DetergentInML -= requiredDetergent;
                    }
                    else
                    {
                        isDetergentOver = true;
                        break;
                    }
                }

                counter++;
                command = Console.ReadLine();
            }

            if (isDetergentOver)
            {
                Console.WriteLine($"Not enough detergent, {requiredDetergent - DetergentInML} ml. more necessary!");
            }
            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesWashed} dishes and {potsWashed} pots were washed.");
                Console.WriteLine($"Leftover detergent {DetergentInML} ml.");
            }
        }
    }
}
