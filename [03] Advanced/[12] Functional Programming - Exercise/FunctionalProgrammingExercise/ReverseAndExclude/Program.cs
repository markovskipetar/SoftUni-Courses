namespace ReverseAndExclude
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divider = int.Parse(Console.ReadLine());

            Func<int, bool> isNotDivisible = n => n % divider != 0;

            numbers = numbers
                .Where(isNotDivisible)
                .ToArray();

            Func<int[], int[]> reverse = new Func<int[], int[]>(arr =>
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    int temp = arr[i];

                    arr[i] = arr[arr.Length - i - 1];
                    arr[arr.Length - i - 1] = temp;
                }

                return arr;
            });

            numbers = reverse(numbers);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
