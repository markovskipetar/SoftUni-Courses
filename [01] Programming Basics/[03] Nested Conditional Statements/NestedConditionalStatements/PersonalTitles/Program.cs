﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string title = "";

            if (gender == "m")
            {
                if (age < 16)
                {
                    title = "Master";
                }
                else
                {
                    title = "Mr.";
                }
            }
            else
            {
                if (age < 16)
                {
                    title = "Miss";
                }
                else
                {
                    title = "Ms.";
                }
            }

            Console.WriteLine(title);
        }
    }
}
