
int[] input = Console.ReadLine()
    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    int[] currentRow = Console.ReadLine()
    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = currentRow[j];
    }
}

int maxSum = 0;
int maxSumRow = 0;
int maxSumCol = 0;

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxSumRow = row;
            maxSumCol = col;
        }
    }
}

Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]}");
Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]}");
Console.WriteLine(maxSum);