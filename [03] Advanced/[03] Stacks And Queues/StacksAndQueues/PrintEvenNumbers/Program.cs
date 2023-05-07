namespace PrintEvenNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToArray();

            var queue = new Queue<int>();

            foreach (var number in numbers)
            {
                queue.Enqueue(number);
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
