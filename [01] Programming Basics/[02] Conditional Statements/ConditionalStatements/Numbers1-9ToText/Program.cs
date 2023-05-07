using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers1_9ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string numberInText = "";

            switch (inputNumber)
            {
                case 1:
                    numberInText = "one";
                    break;

                case 2:
                    numberInText = "two";
                    break;

                case 3:
                    numberInText = "three";
                    break;

                case 4:
                    numberInText = "four";
                    break;

                case 5:
                    numberInText = "five";
                    break;

                case 6:
                    numberInText = "six";
                    break;

                case 7:
                    numberInText = "seven";
                    break;

                case 8:
                    numberInText = "eight";
                    break;

                case 9:
                    numberInText = "nine";
                    break;

                default:
                    numberInText = "number too big";
                    break;
            }
            Console.WriteLine(numberInText);
        }
    }
}
