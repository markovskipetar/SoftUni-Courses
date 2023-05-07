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
            int students = int.Parse(Console.ReadLine());

            double between2_00And2_99 = 0;
            double between3_00And3_99 = 0;
            double between4_00And4_99 = 0;
            double overOrEqualTo5_00 = 0;

            double totalGrades = 0;

            for (int i = 0; i < students; i++)
            {
                double currentStudentGrade = double.Parse(Console.ReadLine());

                totalGrades += currentStudentGrade;

                if (2 <= currentStudentGrade && currentStudentGrade <= 2.99)
                {
                    between2_00And2_99++;
                }
                else if (3 <= currentStudentGrade && currentStudentGrade <= 3.99)
                {
                    between3_00And3_99++;
                }
                else if (4 <= currentStudentGrade && currentStudentGrade <= 4.99)
                {
                    between4_00And4_99++;
                }
                else
                {
                    overOrEqualTo5_00++;
                }
            }


            Console.WriteLine($"Top students: {overOrEqualTo5_00 / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4_00And4_99 / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3_00And3_99 / students * 100:f2}%");
            Console.WriteLine($"Fail: {between2_00And2_99 / students * 100:f2}%");
            Console.WriteLine($"Average: {totalGrades / students:f2}");
        }
    }
}
