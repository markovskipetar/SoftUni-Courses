namespace Crossroads
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());

            int passedCarsCounter = 0;
            var cars = new Queue<string>();

            bool crashHappend = false;
            string hitMessage = "";

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (command == "green")
                {
                    int currentGreenLightSeconds = greenLightSeconds;

                    while (cars.Any())
                    {
                        string car = cars.Dequeue();
                        int carLength = car.Length;

                        if (currentGreenLightSeconds >= carLength)
                        {
                            currentGreenLightSeconds -= carLength;

                            passedCarsCounter++;

                            if (currentGreenLightSeconds == 0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            int passedLetters = currentGreenLightSeconds;
                            int leftLetters = carLength - passedLetters;

                            if (freeWindowSeconds >= leftLetters)
                            {
                                passedCarsCounter++;
                            }
                            else
                            {
                                crashHappend = true;
                                hitMessage = $"{car} was hit at {car[passedLetters + freeWindowSeconds]}.";
                            }

                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                if (crashHappend)
                {
                    break;
                }
            }

            if (!crashHappend)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine(passedCarsCounter + " total cars passed the crossroads.");
            }
            else
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine(hitMessage);
            }
        }
    }
}
