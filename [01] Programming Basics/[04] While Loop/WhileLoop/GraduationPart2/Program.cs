using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int passedClassesCount = 0;
            int excludedTimesCount = 0;

            double gradesSum = 0;
            bool isExcluded = false;

            while (passedClassesCount < 12)
            {
                double currentClassGrade = double.Parse(Console.ReadLine());

                if (currentClassGrade >= 4)
                {
                    gradesSum += currentClassGrade;
                    passedClassesCount++;
                }
                else
                {
                    excludedTimesCount++;
                }

                if (excludedTimesCount >= 2)
                {
                    isExcluded = true;
                    break;
                }
            }

            if (isExcluded)
            {
                Console.WriteLine($"{name} has been excluded at {passedClassesCount + 1} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradesSum / 12:f2}");
            }
        }
    }
}
