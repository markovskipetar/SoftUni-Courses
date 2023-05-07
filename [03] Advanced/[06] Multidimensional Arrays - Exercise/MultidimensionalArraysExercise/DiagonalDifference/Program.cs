int size = int.Parse(Console.ReadLine());

int[,] matrix = ReadMatrix(size, size);

int mainDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int i = 0; i < size; i++)
{
    mainDiagonalSum += matrix[i, i];
    secondaryDiagonalSum += matrix[i, size - i - 1];
}

Console.WriteLine(Math.Abs(mainDiagonalSum - secondaryDiagonalSum));

static int[,] ReadMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] rowValues = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }

    return matrix;
}

static void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}





