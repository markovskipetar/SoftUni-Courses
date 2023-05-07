namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] personData = Console.ReadLine().Split().ToArray();

                if (personData[0] == "END")
                {
                    break;
                }

                string name = personData[0];
                int age = int.Parse(personData[1]);
                string town = personData[2];

                Person person = new Person(name, age, town);

                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[index];

            int matches = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (personToCompare.CompareTo(people[i]) == 0)
                {
                    matches++;
                }
            }

            int nonMatches = people.Count - matches;

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {nonMatches} {people.Count}");
            }
        }
    }
}
