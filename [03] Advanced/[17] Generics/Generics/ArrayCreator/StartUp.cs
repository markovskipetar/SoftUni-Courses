namespace ArrayCreator
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            string[] stringArr = Creator.Create(10, "asd");

            foreach (var item in stringArr)
            {
                Console.WriteLine(item);
            }

            int[] intArr = Creator.Create(5, 9);

            foreach (var item in intArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
