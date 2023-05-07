namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student currentStudent = new Student(firstName, lastName, grade);

                students.Add(currentStudent);
            }

            students = students.OrderByDescending(student => student.Grade).ToList();

            Console.WriteLine(String.Join("\n", students));
        }
    }
}
