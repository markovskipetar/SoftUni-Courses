using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double familyMemberIncome = double.Parse(Console.ReadLine());
            double schoolSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double excellentScholarship = 0;


            if (familyMemberIncome < minimalSalary && schoolSuccess > 4.5)
            {
                socialScholarship = 0.35 * minimalSalary;
            }

            if (schoolSuccess > 5.5)
            {
                excellentScholarship = schoolSuccess * 25;
            }

            if (socialScholarship > excellentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (excellentScholarship > socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else
            {
                if (socialScholarship == 0 && excellentScholarship == 0)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (socialScholarship == excellentScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                }
            }
        }
    }
}
