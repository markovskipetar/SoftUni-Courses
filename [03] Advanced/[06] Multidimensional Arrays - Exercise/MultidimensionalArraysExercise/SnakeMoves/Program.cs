int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string word = Console.ReadLine();

int rows = input[0];
int cols = input[1];

char[,] matrix = new char[rows, cols];

int index = 0;

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        int tempCol = col;

        if (row % 2 == 1)
        {
            tempCol = cols - col - 1;
        }

        matrix[row, tempCol] = word[index++];

        if (index == word.Length)
        {
            index = 0;
        }
    }
}

PrintMatrix(matrix);

static void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }
}