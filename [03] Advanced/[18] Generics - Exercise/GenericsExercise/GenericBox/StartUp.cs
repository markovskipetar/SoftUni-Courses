namespace GenericBox
{
    using System;
    using System.Collections.Generic;

    internal class StartUp
    {
        static void Main()
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            list.Add(1);
            list.Add(2);
            
            Console.WriteLine(list.Remove());
        }
    }
}
