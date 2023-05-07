int[] input = Console.ReadLine()
    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] currentRow = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentRow[col];
    }
}

for (int col = 0; col < cols; col++)
{
    int currentColSum = 0;

    for (int row = 0; row < rows; row++)
    {
        currentColSum += matrix[row, col];
    }

    Console.WriteLine(currentColSum);
}