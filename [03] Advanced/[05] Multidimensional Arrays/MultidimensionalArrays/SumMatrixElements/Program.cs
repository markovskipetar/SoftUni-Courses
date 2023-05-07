
int[] input = Console.ReadLine()
    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];
int matrixSum = 0;

for (int i = 0; i < rows; i++)
{
    int[] currentRow = Console.ReadLine()
    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = currentRow[j];
        matrixSum+= currentRow[j];
    }
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(matrixSum);