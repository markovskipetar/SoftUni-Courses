using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = hours * 60 + minutes + 15;

            if(timeInMinutes / 60 == 24)
            {
                Console.WriteLine($"0:{timeInMinutes % 60:D2}");
            }
            else
            {
                Console.WriteLine($"{timeInMinutes / 60}:{timeInMinutes % 60:D2}");
            }
        }
    }
}
