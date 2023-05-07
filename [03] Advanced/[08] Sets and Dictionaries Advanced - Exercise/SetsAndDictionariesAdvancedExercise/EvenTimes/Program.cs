namespace EvenTimes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            var numbersCounts = new Dictionary<int, int>();

            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!numbersCounts.ContainsKey(num))
                {
                    numbersCounts[num] = 0;
                }

                numbersCounts[num]++;
            }

            var kvpResult = numbersCounts.First(kvp => kvp.Value % 2 == 0);

            Console.WriteLine(kvpResult.Key);
        }
    }
}
