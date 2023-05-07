using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int neighbourAnimals = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numberOfDogs * 2.50 + neighbourAnimals * 4.00:F2} lv");
        }
    }
}
