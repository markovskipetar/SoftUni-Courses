namespace ActionPoint
{
    using System;

    internal class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printNamess = text => Console.WriteLine(string.Join(Environment.NewLine, text));

            printNamess(names);
        }
    }
}
