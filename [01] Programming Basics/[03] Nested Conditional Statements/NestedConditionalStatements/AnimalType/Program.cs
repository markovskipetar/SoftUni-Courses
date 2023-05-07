using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string animalType = "";

            if (animal == "dog")
            {
                animalType = "mammal";
            }
            else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
            {
                animalType = "reptile";
            }
            else
            {
                animalType = "unknown";
            }

            Console.WriteLine(animalType);
        }
    }
}
