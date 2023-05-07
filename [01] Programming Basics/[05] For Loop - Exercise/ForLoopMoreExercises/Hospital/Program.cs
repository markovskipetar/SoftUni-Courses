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
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treatedPeople = 0;
            int untreatedPeople = 0;

            for (int i = 0; i < period; i++)
            {
                int currentDay = i + 1;

                if (currentDay % 3 == 0 && untreatedPeople > treatedPeople)
                {
                    doctors++;
                }

                int patietnsForTheDay = int.Parse(Console.ReadLine());

                if (doctors >= patietnsForTheDay)
                {
                    treatedPeople += patietnsForTheDay;
                }
                else
                {
                    treatedPeople += doctors;
                    untreatedPeople += patietnsForTheDay - doctors;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPeople}.");
            Console.WriteLine($"Untreated patients: {untreatedPeople}.");
        }
    }
}
