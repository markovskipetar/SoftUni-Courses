namespace BasicQueueOperations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numbersToDequeue = input[1];
            int numberToFind = input[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(numbers);

            for (int i = 0; i < numbersToDequeue && queue.Any(); i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
