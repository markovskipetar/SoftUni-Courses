namespace AppliedArithmetics
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

            Action<int[]> print = nums => Console.WriteLine(String.Join(" ", nums));

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "print")
                {
                    print(numbers);
                }
                else
                {
                    Func<int[], int[]> manipulate = GetProccess(input);

                    numbers = manipulate(numbers);
                }
            }
        }

        private static Func<int[], int[]> GetProccess(string input)
        {
            Func<int[], int[]> func = null;

            if (input == "add")
            {
                func = new Func<int[], int[]>(arr =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]++;
                    }

                    return arr;
                });
            }
            else if (input == "subtract")
            {
                func = new Func<int[], int[]>(arr =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }

                    return arr;
                });
            }
            else if (input == "multiply")
            {
                func = new Func<int[], int[]>(arr =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] *= 2;
                    }

                    return arr;
                });
            }

            return func;
        }
    }
}
