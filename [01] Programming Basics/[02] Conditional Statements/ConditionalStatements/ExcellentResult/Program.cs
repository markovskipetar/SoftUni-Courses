using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double schoolGrade = double.Parse(Console.ReadLine());

            if(schoolGrade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
