using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingByName
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");
        }
    }
}
