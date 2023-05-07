namespace HotPotato
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var names = Console.ReadLine().Split().ToArray();
            int toss = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(names);
            int counter = 1;

            while (queue.Count > 1)
            {
                if (counter == toss)
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                    counter = 1;
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                    counter++;
                }
            }

            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
