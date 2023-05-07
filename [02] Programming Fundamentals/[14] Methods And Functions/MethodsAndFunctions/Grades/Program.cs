using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            string gradeInWords = GetGradeInWords(grade);

            Console.WriteLine(gradeInWords);
        }

        static string GetGradeInWords(double grade)
        {
            if (2.00 <= grade && grade <= 2.99)
            {
                return "Fail";
            }
            else if (3.00 <= grade && grade <= 3.49)
            {
                return "Poor";
            }
            else if (3.50 <= grade && grade <= 4.49)
            {
                return "Good";
            }
            else if (4.50 <= grade && grade <= 5.49)
            {
                return "Very good";
            }
            else
            {
                return "Excellent";
            }
        }
    }
}
