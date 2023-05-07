using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "end")
                {
                    Console.WriteLine($"[{String.Join(", ", numbers)}]");

                    break;
                }

                if (command == "exchange")
                {
                    int index = int.Parse(input[1]);

                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeNumbers(numbers, index);
                    }
                }
                else if (command == "max")
                {
                    string typeOfNumber = input[1];

                    int moduleDivisonResult = 0;

                    if (typeOfNumber == "odd")
                    {
                        moduleDivisonResult = 1;
                    }

                    int maxNumberIndex = GetMaxNumberIndex(numbers, moduleDivisonResult);

                    if (maxNumberIndex == -1)
                    {
                        Console.WriteLine($"No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxNumberIndex);
                    }
                }
                else if (command == "min")
                {
                    string typeOfNumber = input[1];

                    int moduleDivisonResult = 0;

                    if (typeOfNumber == "odd")
                    {
                        moduleDivisonResult = 1;
                    }

                    int minNumberIndex = GetMinNumberIndex(numbers, moduleDivisonResult);

                    if (minNumberIndex == -1)
                    {
                        Console.WriteLine($"No matches");
                    }
                    else
                    {
                        Console.WriteLine(minNumberIndex);
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(input[1]);

                    if (count > numbers.Length)
                    {
                        Console.WriteLine($"Invalid count");
                    }
                    else
                    {
                        string typeOfNumber = input[2];

                        int moduleDivisonResult = 0;

                        if (typeOfNumber == "odd")
                        {
                            moduleDivisonResult = 1;
                        }

                        int[] firstNumbers = GetFirstNumbers(numbers, moduleDivisonResult, count);

                        if (firstNumbers.Length == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine($"[{String.Join(", ", firstNumbers)}]");
                        }
                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(input[1]);

                    if (count > numbers.Length)
                    {
                        Console.WriteLine($"Invalid count");
                    }
                    else
                    {
                        string typeOfNumber = input[2];

                        int moduleDivisonResult = 0;

                        if (typeOfNumber == "odd")
                        {
                            moduleDivisonResult = 1;
                        }

                        int[] lastNumbers = GetLastNumbers(numbers, moduleDivisonResult, count);

                        if (lastNumbers.Length == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine($"[{String.Join(", ", lastNumbers)}]");
                        }
                    }
                }
            }
        }

        static void ExchangeNumbers(int[] numbers, int index)
        {
            int[] tempArray = new int[index + 1];

            for (int i = 0; i < index + 1; i++)
            {
                tempArray[i] = numbers[i];
            }

            int moveCounter = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                numbers[moveCounter] = numbers[i];

                moveCounter++;
            }

            int tempArrrayCounter = 0;

            for (int i = moveCounter; i < numbers.Length; i++)
            {
                numbers[i] = tempArray[tempArrrayCounter];

                tempArrrayCounter++;
            }
        }

        static int GetMaxNumberIndex(int[] numbers, int moduleDivisonResult)
        {
            int maxNumber = int.MinValue;
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == moduleDivisonResult && currentNumber >= maxNumber)
                {
                    maxNumber = currentNumber;
                    index = i;
                }
            }

            return index;
        }

        static int GetMinNumberIndex(int[] numbers, int moduleDivisonResult)
        {
            int minNumber = int.MaxValue;
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == moduleDivisonResult && currentNumber <= minNumber)
                {
                    minNumber = currentNumber;
                    index = i;
                }
            }

            return index;
        }

        static int[] GetFirstNumbers(int[] numbers, int moduleDivisonResult, int count)
        {
            string firstNumbersSequence = String.Empty;

            int tempCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == moduleDivisonResult)
                {
                    if (tempCounter == count)
                    {
                        break;
                    }

                    firstNumbersSequence += currentNumber.ToString() + " ";
                    tempCounter++;
                }
            }

            int[] firstNumbers = firstNumbersSequence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            return firstNumbers;
        }

        static int[] GetLastNumbers(int[] numbers, int moduleDivisonResult, int count)
        {
            string lastNumbersSequence = String.Empty;

            int tempCounter = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == moduleDivisonResult)
                {
                    lastNumbersSequence += currentNumber.ToString() + " ";
                    tempCounter++;

                    if (tempCounter == count)
                    {
                        break;
                    }
                }
            }

            int[] lastNumbers = lastNumbersSequence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            ReverseArray(lastNumbers);

            return lastNumbers;
        }

        static void ReverseArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int lastElement = numbers[numbers.Length - i - 1];

                numbers[numbers.Length - i - 1] = numbers[i];
                numbers[i] = lastElement;
            }
        }
    }
}
