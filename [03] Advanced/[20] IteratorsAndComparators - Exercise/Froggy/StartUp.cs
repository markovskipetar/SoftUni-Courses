namespace Froggy
{
    using System;
    using System.Linq;

    internal class StartUp
    {
        static void Main()
        {
            int[] rocks = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Lake lake = new Lake(rocks);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
