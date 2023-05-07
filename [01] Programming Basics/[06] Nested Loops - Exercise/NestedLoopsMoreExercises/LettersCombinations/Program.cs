using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char intervalBegginning = char.Parse(Console.ReadLine());
            char intervalEnd = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = intervalBegginning; i <= intervalEnd; i++)
            {
                if (i == skipLetter)
                {
                    continue;
                }

                for (char j = intervalBegginning; j <= intervalEnd; j++)
                {
                    if (j == skipLetter)
                    {
                        continue;
                    }

                    for (char k = intervalBegginning; k <= intervalEnd; k++)
                    {
                        if (k == skipLetter)
                        {
                            continue;
                        }

                        Console.Write($"{i}{j}{k} ");
                        counter++;
                    }
                }
            }

            Console.Write(counter);
            Console.WriteLine();
        }
    }
}
