namespace CustomComparator
{
    using System;
    using System.Linq;

    internal class StartUp
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(nums, new CustomComparator());

            Console.WriteLine(String.Join(" ",nums));
        }
    }
}
