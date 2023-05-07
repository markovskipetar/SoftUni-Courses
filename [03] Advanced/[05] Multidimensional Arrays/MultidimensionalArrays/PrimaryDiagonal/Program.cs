int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];
int mainDiagonalSum = 0;

for (int row = 0; row < size; row++)
{
    int[] currentRow = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = currentRow[col];

        if (row == col)
        {
            mainDiagonalSum += matrix[row, col];
        }
    }
}

Console.WriteLine(mainDiagonalSum);