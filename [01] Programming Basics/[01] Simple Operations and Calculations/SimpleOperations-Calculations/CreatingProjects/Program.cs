using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {architectName} will need {numberOfProjects * 3} hours to complete {numberOfProjects} project/s.");
        }
    }
}
