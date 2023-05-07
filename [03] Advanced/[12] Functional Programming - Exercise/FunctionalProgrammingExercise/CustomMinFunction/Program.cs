namespace CustomMinFunction
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> min = new Func<int[], int>(arr =>
            {
                int min = int.MaxValue;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }

                return min;
            });

            Console.WriteLine(min(numbers));
        }
    }
}
