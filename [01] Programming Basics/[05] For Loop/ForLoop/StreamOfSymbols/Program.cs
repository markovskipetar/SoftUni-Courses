using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamOfSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();

            for (int i = 0; i < inputWord.Length; i++)
            {
                Console.WriteLine(inputWord[i]);
            }
        }
    }
}
