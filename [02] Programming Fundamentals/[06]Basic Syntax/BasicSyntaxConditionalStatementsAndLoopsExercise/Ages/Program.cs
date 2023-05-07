using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string stageOfLife = String.Empty;

            if (age <= 2)
            {
                stageOfLife = "baby";
            }
            else if (age <= 13)
            {
                stageOfLife = "child";
            }
            else if (age <= 19)
            {
                stageOfLife = "teenager";
            }
            else if (age <= 65)
            {
                stageOfLife = "adult";
            }
            else
            {
                stageOfLife = "elder";
            }

            Console.WriteLine(stageOfLife);
        }
    }
}
