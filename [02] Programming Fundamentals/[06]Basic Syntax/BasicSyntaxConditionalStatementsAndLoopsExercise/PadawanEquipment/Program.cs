using System;
using System.Diagnostics.CodeAnalysis;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int totalBelts = studentsCount - (studentsCount / 6);
            double totalLightsabres = Math.Ceiling(studentsCount * 1.1);

            double moneyForLightsabres = (totalLightsabres) * lightsaberPrice;
            double moneyForRobes = studentsCount * robePrice;
            double moneyForBelts = totalBelts * beltPrice;

            double totalMoney = moneyForLightsabres + moneyForRobes + moneyForBelts;

            if (availableMoney >= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalMoney - availableMoney:F2}lv more.");
            }
        }
    }
}
