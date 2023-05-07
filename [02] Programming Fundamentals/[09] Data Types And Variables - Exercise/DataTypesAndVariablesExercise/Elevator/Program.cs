using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = passengers / capacity;
            int extraCourses = passengers % capacity;

            if (extraCourses != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
