using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsetsCount = 0;
            int trashedMousesCount = 0;
            int trashedKeyboardsCount = 0;
            int trashedDisplaysCount = 0;

            int tempKeyboardCounter = 0;

            for (int i = 0; i < lostGamesCount; i++)
            {
                int currentGameNumber = i + 1;

                if (currentGameNumber % 2 == 0)
                {
                    trashedHeadsetsCount++;
                }

                if (currentGameNumber % 3 == 0)
                {
                    trashedMousesCount++;
                }

                if (currentGameNumber % 2 == 0 && currentGameNumber % 3 == 0)
                {
                    trashedKeyboardsCount++;
                    tempKeyboardCounter++;
                }

                if (tempKeyboardCounter % 2 == 0 && tempKeyboardCounter >= 1)
                {
                    trashedDisplaysCount++;
                    tempKeyboardCounter = 0;
                }
            }

            double moneyForHeadsets = trashedHeadsetsCount * headsetPrice;
            double moneyForMouses = trashedMousesCount * mousePrice;
            double moneyForKeyboards = trashedKeyboardsCount * keyboardPrice;
            double moneyForDisplays = trashedDisplaysCount * displayPrice;

            double totalNeededMoney = moneyForHeadsets + moneyForMouses + moneyForKeyboards + moneyForDisplays;

            Console.WriteLine($"Rage expenses: {totalNeededMoney:F2} lv.");
        }
    }
}
