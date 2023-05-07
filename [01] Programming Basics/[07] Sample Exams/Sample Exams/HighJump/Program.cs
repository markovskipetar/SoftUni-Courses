using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedHeigh = int.Parse(Console.ReadLine());
            int currentHeight = wantedHeigh - 30;

            int jumps = 0;
            bool isReached = false;

            bool isFailed = false;
            int failedHeigh = 0;

            while (true)
            {
                int currentJump = int.Parse(Console.ReadLine());
                jumps++;

                if (currentHeight == wantedHeigh)
                {
                    if (currentJump > wantedHeigh)
                    {
                        isReached = true;
                        break;
                    }
                    else
                    {
                        int fails = 1;

                        for (int i = 0; i < 2; i++)
                        {
                            currentJump = int.Parse(Console.ReadLine());
                            jumps++;

                            if (currentJump > wantedHeigh)
                            {
                                isReached = true;
                                break;
                            }
                            else
                            {
                                fails++;
                            }
                        }

                        if (isReached)
                        {
                            break;
                        }

                        if (fails == 3)
                        {
                            isFailed = true;
                            failedHeigh = currentHeight;
                            break;
                        }
                    }
                }
                else
                {
                    if (currentJump > currentHeight)
                    {
                        currentHeight += 5;
                    }
                    else
                    {
                        int fails = 1;

                        for (int i = 0; i < 2; i++)
                        {
                            currentJump = int.Parse(Console.ReadLine());
                            jumps++;

                            if (currentJump > currentHeight)
                            {
                                currentHeight += 5;
                                break;
                            }
                            else
                            {
                                fails++;
                            }

                        }
                        if (fails == 3)
                        {
                            isFailed = true;
                            failedHeigh = currentHeight;
                            break;
                        }
                        if (isReached)
                        {
                            break;
                        }
                    }
                }
            }

            if (isReached)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {wantedHeigh}cm after {jumps} jumps.");
            }
            else if (isFailed)
            {
                Console.WriteLine($"Tihomir failed at {failedHeigh}cm after {jumps} jumps.");
            }
        }
    }
}
