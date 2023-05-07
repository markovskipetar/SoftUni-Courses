using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string weekDay = "";

            if (number == 1)
            {
                weekDay = "Monday";
            }
            else if (number == 2)
            {
                weekDay = "Tuesday";

            }
            else if (number == 3)
            {
                weekDay = "Wednesday";

            }
            else if (number == 4)
            {
                weekDay = "Thursday";

            }
            else if (number == 5)
            {
                weekDay = "Friday";

            }
            else if (number == 6)
            {
                weekDay = "Saturday";

            }
            else if (number == 7)
            {
                weekDay = "Sunday";

            }
            else
            {
                weekDay = "Error";
            }

            Console.WriteLine(weekDay);
        }
    }
}
