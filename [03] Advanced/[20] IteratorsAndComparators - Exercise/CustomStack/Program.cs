namespace CustomStack
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stacks = new MyStack<int>();

            foreach (var item in stacks)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stacks)
            {
                Console.WriteLine(item);
            }
        }
    }
}
