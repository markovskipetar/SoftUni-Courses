namespace WallDestroyer
{
    using System;

    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] playerInitialCoordinates = new int[2];
            char[,] table = ReadTable(size, playerInitialCoordinates);

            int playerRow = playerInitialCoordinates[0];
            int playerCol = playerInitialCoordinates[1];

            int holesCount = 0;
            int rodsCount = 0;

            bool isElectrocuted = false;

            while (true)
            {
                string direction = Console.ReadLine();

                if (direction == "End")
                {
                    holesCount++;

                    break;
                }

                Func<int, bool> isNextValid = ValidateNextPostion(direction, size);

                if (direction == "down")
                {
                    if (isNextValid(playerRow))
                    {
                        char nextPositionSymbol = table[playerRow + 1, playerCol];

                        if (nextPositionSymbol == '-')
                        {
                            table[playerRow, playerCol] = '*';
                            holesCount++;

                            playerRow++;

                            table[playerRow, playerCol] = 'V';
                        }
                        else if (nextPositionSymbol == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rodsCount++;
                        }
                        else if (nextPositionSymbol == 'C')
                        {
                            holesCount += 2;
                            table[playerRow, playerCol] = '*';

                            table[playerRow + 1, playerCol] = 'E';
                            isElectrocuted = true;

                            break;
                        }
                        else if (nextPositionSymbol == '*')
                        {
                            table[playerRow, playerCol] = '*';

                            playerRow++;

                            table[playerRow, playerCol] = 'V';

                            Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
                        }
                    }
                }
                else if (direction == "up")
                {
                    if (isNextValid(playerRow))
                    {
                        char nextPositionSymbol = table[playerRow - 1, playerCol];

                        if (nextPositionSymbol == '-')
                        {
                            table[playerRow, playerCol] = '*';
                            holesCount++;

                            playerRow--;

                            table[playerRow, playerCol] = 'V';
                        }
                        else if (nextPositionSymbol == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rodsCount++;
                        }
                        else if (nextPositionSymbol == 'C')
                        {
                            holesCount += 2;
                            table[playerRow, playerCol] = '*';

                            table[playerRow - 1, playerCol] = 'E';
                            isElectrocuted = true;

                            break;
                        }
                        else if (nextPositionSymbol == '*')
                        {
                            table[playerRow, playerCol] = '*';

                            playerRow--;

                            table[playerRow, playerCol] = 'V';

                            Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
                        }
                    }
                }
                else if (direction == "left")
                {
                    if (isNextValid(playerCol))
                    {
                        char nextPositionSymbol = table[playerRow, playerCol - 1];

                        if (nextPositionSymbol == '-')
                        {
                            table[playerRow, playerCol] = '*';
                            holesCount++;

                            playerCol--;

                            table[playerRow, playerCol] = 'V';
                        }
                        else if (nextPositionSymbol == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rodsCount++;
                        }
                        else if (nextPositionSymbol == 'C')
                        {
                            holesCount += 2;
                            table[playerRow, playerCol] = '*';

                            table[playerRow, playerCol - 1] = 'E';
                            isElectrocuted = true;

                            break;
                        }
                        else if (nextPositionSymbol == '*')
                        {
                            table[playerRow, playerCol] = '*';

                            playerCol--;

                            table[playerRow, playerCol] = 'V';

                            Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
                        }
                    }
                }
                else if (direction == "right")
                {
                    if (isNextValid(playerCol))
                    {
                        char nextPositionSymbol = table[playerRow, playerCol + 1];

                        if (nextPositionSymbol == '-')
                        {
                            table[playerRow, playerCol] = '*';
                            holesCount++;

                            playerCol++;

                            table[playerRow, playerCol] = 'V';
                        }
                        else if (nextPositionSymbol == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rodsCount++;
                        }
                        else if (nextPositionSymbol == 'C')
                        {
                            holesCount += 2;
                            table[playerRow, playerCol] = '*';

                            table[playerRow, playerCol + 1] = 'E';
                            isElectrocuted = true;

                            break;
                        }
                        else if (nextPositionSymbol == '*')
                        {
                            table[playerRow, playerCol] = '*';

                            playerCol++;

                            table[playerRow, playerCol] = 'V';

                            Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
                        }
                    }
                }
            }

            if (isElectrocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holesCount} hole(s) and " +
                    $"he hit only {rodsCount} rod(s).");
            }

            PrintTable(table);
        }

        private static Func<int, bool> ValidateNextPostion(string direction, int tableSize)
        {
            Func<int, bool> func = direction switch
            {
                "down" => row => row + 1 < tableSize,
                "up" => row => row - 1 >= 0,
                "left" => col => col - 1 >= 0,
                "right" => col => col + 1 < tableSize
            };

            return func;
        }

        public static void StepOnFreePosition(string direction, int currentDow, int currentCol, char[,] table)
        {
            switch (direction)
            {
                case "up":

                    break;
            }
        }

        private static char[,] ReadTable(int size, int[] playerInitialCoordinates)
        {
            char[,] table = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    table[row, col] = line[col];

                    if (line[col] == 'V')
                    {
                        playerInitialCoordinates[0] = row;
                        playerInitialCoordinates[1] = col;
                    }
                }
            }

            return table;
        }

        private static void PrintTable(char[,] table)
        {
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    Console.Write(table[row, col] + "");
                }

                Console.WriteLine();
            }
        }
    }
}
