using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int cinemaCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int income = 0;
            bool isCinemaFull = false;
            int totalPeople = 0;

            while (command != "Movie time!")
            {
                int people = int.Parse(command);

                if (people + totalPeople > cinemaCapacity)
                {
                    isCinemaFull = true;
                    break;
                }

                int currentTotalSum = 5 * people;

                if (people % 3 == 0)
                {
                    currentTotalSum -= 5;
                }

                totalPeople += people;
                income += currentTotalSum;

                if (people == cinemaCapacity)
                {
                    isCinemaFull = true;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isCinemaFull)
            {
                Console.WriteLine("The cinema is full.");
            }
            else
            {
                Console.WriteLine($"There are {cinemaCapacity - totalPeople} seats left in the cinema.");
            }

            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
