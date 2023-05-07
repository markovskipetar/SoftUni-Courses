namespace Supermarket
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var people = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                if (name == "Paid")
                {
                    while (people.Any())
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(name);
                }
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
