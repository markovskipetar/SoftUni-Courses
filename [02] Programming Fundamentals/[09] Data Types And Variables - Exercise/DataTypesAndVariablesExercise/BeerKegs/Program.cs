using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());

            string biggestKeg = String.Empty;
            double biggestKegVolume = 0;

            for (int i = 0; i < kegsCount; i++)
            {
                string currentKegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentKegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currentKegVolume > biggestKegVolume)
                {
                    biggestKeg = currentKegModel;
                    biggestKegVolume = currentKegVolume;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
