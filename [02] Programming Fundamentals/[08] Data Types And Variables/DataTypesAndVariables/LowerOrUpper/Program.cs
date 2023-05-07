using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if ('a' <= letter && letter <= 'z')
            {
                Console.WriteLine("lower-case");
            }
            else if ('A' <= letter && letter <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
