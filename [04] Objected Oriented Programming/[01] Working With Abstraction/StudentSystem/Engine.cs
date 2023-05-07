namespace StudentSystem
{
    using System;

    public class Engine
    {
        public Engine(StudentSystem studentSystem)
        {
            this.studentSystem = studentSystem;
        }

        private StudentSystem studentSystem;

        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "Create")
                {
                    var name = input[1];
                    var age = int.Parse(input[2]);
                    var grade = double.Parse(input[3]);

                    this.studentSystem.Add(name, age, grade);
                }
                else if (command == "Show")
                {
                    var name = input[1];

                    this.studentSystem.Show(name);
                }
                else if (command=="Exit")
                {
                    break;
                }
            }
        }
    }
}
