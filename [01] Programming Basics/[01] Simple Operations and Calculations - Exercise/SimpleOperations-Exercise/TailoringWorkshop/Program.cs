using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tablesCount = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double allTableClothesArea = tablesCount * (tableLenght + (2 * 0.30)) * (tableWidth + (2 * 0.30));
            double allTableToppersArea = tablesCount * (tableLenght / 2) * (tableLenght / 2);

            double moneyForTableClothesInUSD = allTableClothesArea * 7;
            double moneyForTableToppersInUSD = allTableToppersArea * 9;

            double moneyForClothesAndTopperInUSD = moneyForTableClothesInUSD + moneyForTableToppersInUSD;
            double moneyForClothesAndTopperInBGN = moneyForClothesAndTopperInUSD * 1.85;

            Console.WriteLine($"{moneyForClothesAndTopperInUSD:F2} USD");
            Console.WriteLine($"{moneyForClothesAndTopperInBGN:F2} BGN");
        }
    }
}
