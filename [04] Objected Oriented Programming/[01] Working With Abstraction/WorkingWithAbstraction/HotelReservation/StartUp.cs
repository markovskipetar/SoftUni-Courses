using System;
using System.Linq;

namespace HotelReservation
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split().ToArray();

            PriceCalculator calculator = new PriceCalculator();

            calculator.GetTotalPrice(inputData);
        }
    }
}
