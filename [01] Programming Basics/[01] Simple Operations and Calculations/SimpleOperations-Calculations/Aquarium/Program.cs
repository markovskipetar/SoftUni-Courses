using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int aquariumLength = int.Parse(Console.ReadLine());
            int aquariumWidth = int.Parse(Console.ReadLine());
            int aquariumHeight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            percent *= 0.01;
            double aquariumVolume = aquariumLength * aquariumWidth * aquariumHeight;
            double aquariumVolumeInLitres = aquariumVolume * 0.001;
            Console.WriteLine($"{aquariumVolumeInLitres * (1 - percent):F3}"); 
        }
    }
}
