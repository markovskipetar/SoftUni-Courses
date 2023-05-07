namespace JediGalaxy
{
    public class Program
    {
        static void Main()
        {
            int[] matrixDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] playerStartCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] evilStartCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.ReadLine();

            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);

            Dictionary<int, int> rowCol = new Dictionary<int, int>();

            int playerRow = playerStartCoordinates[0];
            int playerCol = playerStartCoordinates[1];

            int evilRow = evilStartCoordinates[0];
            int evilCol = evilStartCoordinates[1];

            int totalValue = 0;

            while (true)
            {
                if (!(playerRow >= rows || playerCol < 0))
                {
                    rowCol[playerRow] = playerCol;

                    int value = matrix[playerRow, playerCol];

                    totalValue += value;

                    if (playerRow == 0 || playerCol == rows - 1)
                    {
                        break;
                    }
                }

                playerRow--;
                playerCol++;
            }

            while (true)
            {
                if (!(evilRow >= rows || evilCol >= cols))
                {
                    if (rowCol.ContainsKey(evilRow))
                    {
                        if (rowCol[evilRow] == evilCol)
                        {
                            totalValue -= matrix[evilRow, evilCol];
                            break;
                        }
                    }

                    if (evilRow == 0 || evilCol == 0)
                    {
                        break;
                    }
                }

                evilRow--;
                evilCol--;
            }

            Console.WriteLine(totalValue);
        }

        private static void FillMatrix(int[,] matrix)
        {
            int number = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = number++;
                }
            }
        }
    }
}