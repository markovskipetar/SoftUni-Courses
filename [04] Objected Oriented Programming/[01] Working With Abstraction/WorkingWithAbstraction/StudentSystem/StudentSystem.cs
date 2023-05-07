using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    class StudentSystem
    {
        StudentsDatabase dataBase = new StudentsDatabase();

        public void ParseCommand()
        {
            string[] inputData = Console.ReadLine().Split();

            if (inputData[0] == "Create")
            {
                Create(inputData);
            }
            else if (inputData[0] == "Show")
            {
                Show(inputData);
            }
            else if (inputData[0] == "Exit")
            {
                return;
            }
        }

        public void Create(string[] inputData)
        {
            var name = inputData[1];
            var age = int.Parse(inputData[2]);
            var grade = double.Parse(inputData[3]);

            if (!this.dataBase.Repository.ContainsKey(name))
            {
                var student = new Student(name, age, grade);

                this.dataBase.Repository[name] = student;
            }
        }

        public void Show(string[] inputData)
        {
            var name = inputData[1];

            if (this.dataBase.Repository.ContainsKey(name))
            {
                var student = this.dataBase.Repository[name];

                StringBuilder result = new StringBuilder($"{student.Name} is {student.Age} years old. ");

                CheckGrade(student, result);

                Console.WriteLine(result.ToString());
            }
        }

        public void CheckGrade(Student student, StringBuilder result)
        {
            if (student.Grade >= 5.00)
            {
                result.Append("Excellent student.");
            }
            else if (student.Grade < 5.00 && student.Grade >= 3.50)
            {
                result.Append("Average student.");
            }
            else
            {
                result.Append("Very nice person.");
            }
        }
    }
}
