using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidaysInTheYear = int.Parse(Console.ReadLine());
            int weekendsAtHome = int.Parse(Console.ReadLine());

            int weekendsInSofia = 48 - weekendsAtHome;

            double playsInSofia = ((double)weekendsInSofia * 3) / 4;
            double playsAtHolidays = ((double)holidaysInTheYear * 2) / 3;
            double totalPlays = weekendsAtHome + playsInSofia + playsAtHolidays;

            if(yearType == "leap")
            {
                totalPlays *= 1.15;
            }

            Console.WriteLine(Math.Floor(totalPlays));
        }
    }
}
