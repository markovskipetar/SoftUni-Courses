using System;

namespace HotelReservation
{
    class PriceCalculator
    {
        enum PricePerDayMultiplier
        {
            Autumn = 1,
            Spring = 2,
            Winter = 3,
            Summer = 4,
        }

        enum Discounts
        {
            SecondVisit = 10,
            VIP = 20,
        }

        public void GetTotalPrice(string[] inputData)
        {
            double pricePerDay = double.Parse(inputData[0]);
            int daysCount = int.Parse(inputData[1]);
            string season = inputData[2];

            int pricePerDayMultiplier = GetPricePerDayMultiplier(season);
            pricePerDay *= pricePerDayMultiplier;

            double discountMultiplier = 1;

            if (inputData.Length == 4)
            {
                string discountType = inputData[3];

                discountMultiplier = GetDiscountMultiplier(discountType);
            }

            double totalPrice = CalculateFinalPrice(pricePerDay, daysCount, discountMultiplier);

            Console.WriteLine($"{totalPrice:f2}");
        }

        public int GetPricePerDayMultiplier(string season)
        {
            switch (season)
            {
                case "Winter":
                    return (int)PricePerDayMultiplier.Winter;
                case "Spring":
                    return (int)PricePerDayMultiplier.Spring;
                case "Summer":
                    return (int)PricePerDayMultiplier.Summer;
                default:
                    return 1;
            }
        }

        public double GetDiscountMultiplier(string discountType)
        {
            double discountMultiplier = 0;

            switch (discountType)
            {
                case "VIP":
                    discountMultiplier = (100 - (int)Discounts.VIP) / 100.0;
                    break;

                case "SecondVisit":
                    discountMultiplier = (100 - (int)Discounts.SecondVisit) / 100.0;
                    break;

                case "None":
                    discountMultiplier = 1;
                    break;
            }

            return discountMultiplier;
        }

        public double CalculateFinalPrice(double pricePerDay, int daysCount, double discountMultiplier)
        {
            double total = (pricePerDay * daysCount) * discountMultiplier;

            return total;
        }
    }
}
