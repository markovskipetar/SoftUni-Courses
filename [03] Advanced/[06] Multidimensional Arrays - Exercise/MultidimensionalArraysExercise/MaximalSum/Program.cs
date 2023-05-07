int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

int[,] matrix = ReadMatrix(rows, cols);

int maxRowIndex = 0;
int maxColIndex = 0;
int maxSum = int.MinValue;

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int firstRowSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
        int secondRowSum = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
        int thirdRowSum = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        int sum = firstRowSum + secondRowSum + thirdRowSum;

        if (sum > maxSum)
        {
            maxSum = sum;
            maxRowIndex = row;
            maxColIndex = col;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");

for (int row = maxRowIndex; row < maxRowIndex + 3; row++)
{
    for (int col = maxColIndex; col < maxColIndex + 3; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }

    Console.WriteLine();
}

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