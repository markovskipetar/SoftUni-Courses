using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commision = 0;
            bool isValid = true;

            if (city == "Sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    commision = 0.05 * sales;
                }
                else if (500 < sales && sales <= 1000)
                {
                    commision = 0.07 * sales;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    commision = 0.08 * sales;
                }
                else if (sales > 10000)
                {
                    commision = 0.12 * sales;
                }
                else
                {
                    isValid = false;
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    commision = 0.055 * sales;
                }
                else if (500 < sales && sales <= 1000)
                {
                    commision = 0.08 * sales;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    commision = 0.12 * sales;
                }
                else if (sales > 10000)
                {
                    commision = 0.145 * sales;
                }
                else
                {
                    isValid = false;
                }
            }
            else if (city == "Varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    commision = 0.045 * sales;
                }
                if (500 < sales && sales <= 1000)
                {
                    commision = 0.075 * sales;
                }
                if (1000 < sales && sales <= 10000)
                {
                    commision = 0.10 * sales;
                }
                if (sales > 10000)
                {
                    commision = 0.13 * sales;
                }
            }
            else
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine($"{commision:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
