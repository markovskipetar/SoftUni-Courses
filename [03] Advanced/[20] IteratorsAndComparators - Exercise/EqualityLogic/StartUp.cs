namespace EqualityLogic
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class StartUp
    {
        static void Main()
        {
            int dataCount = int.Parse(Console.ReadLine());

            HashSet<Person> peopleHashSet = new HashSet<Person>();
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();

            for (int i = 0; i < dataCount; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                string name = data[0];
                int age = int.Parse(data[1]);

                Person person = new Person(name, age);

                peopleHashSet.Add(person);
                peopleSortedSet.Add(person);
            }

            Console.WriteLine(peopleHashSet.Count);
            Console.WriteLine(peopleSortedSet.Count);
        }
    }
}
