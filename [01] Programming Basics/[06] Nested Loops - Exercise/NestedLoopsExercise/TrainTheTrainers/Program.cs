using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            double totalGrades = 0;
            int count = 0;

            while (true)
            {
                string presentationName = Console.ReadLine();

                if (presentationName == "Finish")
                {
                    break;
                }

                double presentationGradeSum = 0;

                for (int i = 0; i < juryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    count++;
                    totalGrades += grade;
                    presentationGradeSum += grade;
                }
                double currentAvg = presentationGradeSum / juryCount;

                Console.WriteLine($"{presentationName} - {currentAvg:F2}.");
            }

            Console.WriteLine($"Student's final assessment is {totalGrades / count:F2}.");
        }
    }
}
