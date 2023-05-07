using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayAsNumber = int.Parse(Console.ReadLine());

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayAsNumber < 1 || dayAsNumber > 7)
            {
                Console.WriteLine($"Invalid day!");
            }
            else
            {
                Console.WriteLine(days[dayAsNumber - 1]);
            }
        }
    }
}
