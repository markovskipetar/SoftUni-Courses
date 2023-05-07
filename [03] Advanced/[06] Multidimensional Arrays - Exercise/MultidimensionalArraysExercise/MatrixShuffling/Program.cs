int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

string[,] matrix = ReadMatrix(rows, cols);

while (true)
{
    string[] commandLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (commandLine[0] == "END")
    {
        break;
    }

    if (commandLine[0] == "swap" && commandLine.Length == 5)
    {
        int firstNumRow = int.Parse(commandLine[1]);
        int firstNumCol = int.Parse(commandLine[2]);
        int secondNumRow = int.Parse(commandLine[3]);
        int secondNumCol = int.Parse(commandLine[4]);

        bool areFirstNumCoordsValid = (0 <= firstNumRow && firstNumRow < matrix.GetLength(0)) &&
            (0 <= firstNumCol && firstNumCol < matrix.GetLength(1));
        bool areSecondNumCoordsValid = (0 <= secondNumRow && secondNumRow < matrix.GetLength(0)) &&
            (0 <= secondNumCol && secondNumCol < matrix.GetLength(1));

        if (areFirstNumCoordsValid && areSecondNumCoordsValid)
        {
            string temp = matrix[firstNumRow, firstNumCol];

            matrix[firstNumRow, firstNumCol] = matrix[secondNumRow, secondNumCol];
            matrix[secondNumRow, secondNumCol] = temp;

            PrintMatrix(matrix);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}

static string[,] ReadMatrix(int rows, int cols)
{
    string[,] matrix = new string[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string[] rowValues = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }

    return matrix;
}

static void PrintMatrix(string[,] matrix)
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