namespace WordFilter
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.ReadLine()
                .Split()
                .Where(word => word.Length % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
