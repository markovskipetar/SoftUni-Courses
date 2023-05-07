using System;

namespace RhombusOfStars
{
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            RhombusAsStringDrawer rhombus = new RhombusAsStringDrawer(number);

            rhombus.PrintRhombus();
        }
    }
}
