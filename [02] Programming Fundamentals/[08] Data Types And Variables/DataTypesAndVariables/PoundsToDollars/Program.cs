using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal us = pounds * 1.31M;

            Console.WriteLine($"{us:f3}");
        }
    }
}
