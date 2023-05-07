using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int bigNumber = 0;
            int midNumber = 0;
            int smallNumber = 0;

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    bigNumber = firstNumber;

                    if (thirdNumber > secondNumber)
                    {
                        midNumber = thirdNumber;
                        smallNumber = secondNumber;
                    }
                    else
                    {
                        midNumber = secondNumber;
                        smallNumber = thirdNumber;
                    }
                }
                else
                {
                    bigNumber = thirdNumber;
                    midNumber = firstNumber;
                    smallNumber = secondNumber;
                }
            }
            else
            {
                if (thirdNumber > secondNumber)
                {
                    bigNumber = thirdNumber;
                    midNumber = secondNumber;
                    smallNumber = firstNumber;
                }
                else
                {
                    bigNumber = secondNumber;

                    if (thirdNumber > firstNumber)
                    {
                        midNumber = thirdNumber;
                        smallNumber = firstNumber;
                    }
                    else
                    {
                        midNumber = firstNumber;
                        smallNumber = thirdNumber;
                    }
                }
            }

            Console.WriteLine(bigNumber);
            Console.WriteLine(midNumber);
            Console.WriteLine(smallNumber);
        }
    }
}
