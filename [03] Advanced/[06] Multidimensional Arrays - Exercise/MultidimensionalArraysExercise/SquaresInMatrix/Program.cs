int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

char[,] matrix = ReadMatrix(rows, cols);

int counter = 0;

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        bool isSquareEqual = (matrix[row, col] == matrix[row, col + 1]) && 
            (matrix[row, col + 1] == matrix[row + 1, col + 1]) && 
            (matrix[row + 1, col + 1] == matrix[row + 1, col]);

        if (isSquareEqual)
        {
            counter++;
        }
    }
}

Console.WriteLine(counter);

static char[,] ReadMatrix(int rows, int cols)
{
    char[,] matrix = new char[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        char[] rowValues = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }

    return matrix;
}