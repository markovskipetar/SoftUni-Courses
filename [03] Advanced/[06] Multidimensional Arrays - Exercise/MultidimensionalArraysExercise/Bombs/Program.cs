int size = int.Parse(Console.ReadLine());

long[,] matrix = ReadMatrix(size);

string[] bombs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

for (int i = 0; i < bombs.Length; i++)
{
    int row = int.Parse(bombs[i][0].ToString());
    int col = int.Parse(bombs[i][2].ToString());

    long power = matrix[row, col];

    if (power <= 0)
    {
        continue;
    }

    matrix[row, col] = 0;

    DealDamage(matrix, row - 1, col - 1, power);
    DealDamage(matrix, row - 1, col, power);
    DealDamage(matrix, row - 1, col + 1, power);

    DealDamage(matrix, row, col - 1, power);
    DealDamage(matrix, row, col + 1, power);

    DealDamage(matrix, row + 1, col - 1, power);
    DealDamage(matrix, row + 1, col, power);
    DealDamage(matrix, row + 1, col + 1, power);
}

int counter = 0;
long sum = 0;

foreach (var bomb in matrix)
{
    if (bomb > 0)
    {
        counter++;
        sum += bomb;
    }
}

Console.WriteLine($"Alive cells: {counter}");
Console.WriteLine($"Sum: {sum}");

PrintMatrix(matrix);

void DealDamage(long[,] matrix, int row, int col, long power)
{
    string indexes = $"{row},{col}";

    if ((0 <= row && row < matrix.GetLength(0)) && (0 <= col && col < matrix.GetLength(1)) && (matrix[row, col] > 0))
    {
        matrix[row, col] -= power;
    }
}

static long[,] ReadMatrix(int size)
{
    long[,] matrix = new long[size, size];

    for (int row = 0; row < size; row++)
    {
        int[] rowValues = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        for (int col = 0; col < size; col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }

    return matrix;
}

static void PrintMatrix(long[,] matrix)
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