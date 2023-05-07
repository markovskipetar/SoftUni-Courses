using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());
            int counter = 0;
            string unlockingNumber = String.Empty;

            for (int firstNum = 1; firstNum <= 9; firstNum++)
            {
                for (int secondNum = 1; secondNum <= 9; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <= 9; thirdNum++)
                    {
                        for (int forthNum = 1; forthNum <= 9; forthNum++)
                        {
                            if (firstNum < secondNum && thirdNum > forthNum)
                            {
                                if ((firstNum * secondNum) + (thirdNum * forthNum) == controlValue)
                                {
                                    Console.Write($"{firstNum}{secondNum}{thirdNum}{forthNum} ");
                                    counter++;

                                    if (counter == 4)
                                    {
                                        unlockingNumber = $"{firstNum}{secondNum}{thirdNum}{forthNum}";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine($"No!");
            }
            else if (counter < 4)
            {
                Console.WriteLine();
                Console.WriteLine($"No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {unlockingNumber}");
            }
        }
    }
}
