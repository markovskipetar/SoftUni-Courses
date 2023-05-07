namespace FilterByAge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] personData = Console.ReadLine().Split(", ");

                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person person = new Person(name, age);

                people.Add(person);
            }

            string conditionText = Console.ReadLine();
            int conditionAge = int.Parse(Console.ReadLine());
            string formatText = Console.ReadLine();

            Func<Person, bool> condition = conditionText switch
            {
                "older" => p => p.Age >= conditionAge,
                "younger" => p => p.Age <= conditionAge,
                _ => p => true
            };

            Func<Person, string> format = formatText switch
            {
                "name" => x => x.Name,
                "age" => x => x.Age.ToString(),
                "name age" => x => $"{x.Name} - {x.Age}",
                _ => null
            };

            people
                .Where(condition)
                .Select(format)
                .ToList()
                .ForEach(Console.WriteLine);
        }

        public class Person
        {
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}