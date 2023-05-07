namespace StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        public Dictionary<string, Student> Students { get; set; } = new Dictionary<string, Student>();

        public void Add(string name, int age, double grade)
        {
            if (!this.Students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                this.Students[name] = student;
            }
        }

        public void Show(string name)
        {
            if (this.Students.ContainsKey(name))
            {
                var student = this.Students[name];

                Console.WriteLine(student);
            }
        }
    }
}