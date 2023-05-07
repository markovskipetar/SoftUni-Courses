using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCompetitor = int.Parse(Console.ReadLine());
            int secondCompetitor = int.Parse(Console.ReadLine());
            int thirdCompetitor = int.Parse(Console.ReadLine());

            int totalTime = firstCompetitor + secondCompetitor + thirdCompetitor;

            Console.WriteLine($"{totalTime / 60}:{totalTime % 60:D2}");
        }
    }
}
