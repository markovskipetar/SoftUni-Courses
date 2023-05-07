namespace WorkshopExercise
{
    using System;

    internal class Program
    {
        static void Main()
        {
            DoublyLinkedList list = new DoublyLinkedList();

            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
