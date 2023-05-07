namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                string[] input = inputLine
                    .Split()
                    .ToArray();

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string hometown = input[3];

                bool isStudentDataOverwritten = false;

                foreach (var student in students)
                {
                    string studentFirtName = student.FirstName;
                    string studentLastName = student.LastName;

                    if (firstName == studentFirtName && lastName == studentLastName)
                    {
                        student.Age = age;
                        student.Hometown = hometown;

                        isStudentDataOverwritten = true;
                    }
                }

                if (!isStudentDataOverwritten)
                {
                    Student currentStudent = new Student(firstName, lastName, age, hometown);

                    students.Add(currentStudent);
                }

            }

            string hometownToPrint = Console.ReadLine();

            foreach (var student in students)
            {
                string currentStudentHometown = student.Hometown;

                if (currentStudentHometown == hometownToPrint)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
