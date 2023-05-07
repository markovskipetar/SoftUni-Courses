namespace StudentAcademy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }

                students[studentName].Add(grade);
            }

            students = students
                .Where(kvp => kvp.Value.Average() >= 4.50)
                .OrderByDescending(kvp => kvp.Value.Average())
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
