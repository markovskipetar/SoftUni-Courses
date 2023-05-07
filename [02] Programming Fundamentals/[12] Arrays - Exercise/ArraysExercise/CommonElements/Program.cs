﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstWordsSequence = Console.ReadLine().Split().ToArray();
            string[] secondWordsSequence = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < secondWordsSequence.Length; i++)
            {
                string currentWord = secondWordsSequence[i];

                if (firstWordsSequence.Contains(currentWord))
                {
                    Console.Write(currentWord + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
