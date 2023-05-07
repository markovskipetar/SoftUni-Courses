using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPerLiterPrice = double.Parse(Console.ReadLine()); 
            double beerLiters = double.Parse(Console.ReadLine());      
            double wineLiters = double.Parse(Console.ReadLine());     
            double rakiyaLiters = double.Parse(Console.ReadLine());        
            double whiskeyLiters = double.Parse(Console.ReadLine());      
           
            double rakiyaPerLiterPrice = (whiskeyPerLiterPrice / 2);

            double moneyForRakiya = rakiyaLiters * rakiyaPerLiterPrice;
            double moneyForWine = wineLiters * (rakiyaPerLiterPrice * 0.6);
            double moneyForBeer = beerLiters * (rakiyaPerLiterPrice * 0.2);
            double moneyForWhiskey = whiskeyLiters * whiskeyPerLiterPrice;

            double total = moneyForRakiya + moneyForWine + moneyForBeer + moneyForWhiskey;

            Console.WriteLine($"{total:F2}");
        }
    }
}
