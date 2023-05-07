namespace BoxOfT
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Box<int> boxes = new Box<int>();

            boxes.Add(2);
            boxes.Add(3);
            boxes.Add(4);
            boxes.Add(5);
            boxes.Add(6);

            Console.WriteLine(boxes.Count);

            Console.WriteLine(boxes.Remove());
            Console.WriteLine(boxes.Remove());
            Console.WriteLine(boxes.Remove());
            Console.WriteLine(boxes.Remove());
            Console.WriteLine(boxes.Remove());

            boxes.Add(2);
            boxes.Add(3);

            Console.WriteLine(boxes.Count);
        }
    }
}
