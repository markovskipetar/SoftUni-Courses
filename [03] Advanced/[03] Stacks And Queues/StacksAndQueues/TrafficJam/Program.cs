namespace TrafficJam
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int carsPassingCount = int.Parse(Console.ReadLine());
            int passedCarsCounter = 0;

            var queue = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (command == "green")
                {
                    for (int i = 0; i < carsPassingCount && queue.Any(); i++)
                    {
                        Console.WriteLine(queue.Dequeue() + " passed!");
                        passedCarsCounter++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }

            Console.WriteLine($"{passedCarsCounter} cars passed the crossroads.");
        }
    }
}
