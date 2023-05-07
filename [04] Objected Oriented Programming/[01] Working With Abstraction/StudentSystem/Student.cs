namespace StudentSystem
{
    public class Student
    {
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            string message = $"{this.Name} is {this.Age} years old.";

            if (this.Grade >= 5.00)
            {
                message += " Excellent student.";
            }
            else if (3.50 <= this.Grade && this.Grade < 5.00)
            {
                message += " Average student.";
            }
            else
            {
                message += " Very nice person.";
            }

            return message;
        }
    }
}
