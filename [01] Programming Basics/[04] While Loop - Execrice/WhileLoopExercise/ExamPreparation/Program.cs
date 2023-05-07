using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorMarksCount = int.Parse(Console.ReadLine());

            int poorMarksRecieved = 0;
            double marksCount = 0;
            double marksSum = 0;

            string lastProblem = String.Empty;
            bool isPoorMarksLimitReached = false;


            string problemName = Console.ReadLine();

            while (problemName != "Enough")
            {
                int problemMark = int.Parse(Console.ReadLine());

                marksCount++;
                marksSum += problemMark;

                lastProblem = problemName;

                if (problemMark <= 4)
                {
                    poorMarksRecieved++;
                }

                if (poorMarksRecieved == poorMarksCount)
                {
                    isPoorMarksLimitReached = true;
                    break;
                }

                problemName = Console.ReadLine();
            }

            if (isPoorMarksLimitReached)
            {
                Console.WriteLine($"You need a break, {poorMarksRecieved} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {marksSum / marksCount:f2}");
                Console.WriteLine($"Number of problems: {marksCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
