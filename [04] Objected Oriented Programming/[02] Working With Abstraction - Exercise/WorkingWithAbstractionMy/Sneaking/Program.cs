int rows = int.Parse(Console.ReadLine());

char[,] matrix = InitializeMatrix(rows);

static char[,] InitializeMatrix(int rows)
{
    char[,] matrix = null;

    for (int row = 0; row < rows; row++)
    {
        string line = Console.ReadLine();

        if (row == 0)
        {
            int cols = line.Length;

            matrix = new char[rows, cols];
        }

        for (int col = 0; col < line.Length; col++)
        {
            matrix[row, col] = line[col];
        }
    }

    return matrix;
}

static void Print(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + "");
        }

        Console.WriteLine();
    }
}