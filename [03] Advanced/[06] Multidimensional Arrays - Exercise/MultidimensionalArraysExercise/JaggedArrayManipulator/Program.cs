int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int i = 0; i < rows; i++)
{
    int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    jaggedArray[i] = currentRow;
}

ManipulateRows(rows, jaggedArray);

while (true)
{
    string[] commandLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string command = commandLine[0];

    if (command == "End")
    {
        break;
    }

    int row = int.Parse(commandLine[1]);
    int col = int.Parse(commandLine[2]);
    int value = int.Parse(commandLine[3]);

    switch (command)
    {
        case "Add":
            Add(jaggedArray, row, col, value);
            break;

        case "Subtract":
            Subtract(jaggedArray, row, col, value);
            break;
    }
}

PrintJaggedArray(jaggedArray);

static void Subtract(int[][] jaggedArray, int row, int col, int value)
{
    if ((0 <= row && row < jaggedArray.Length) && (0 <= col && col < jaggedArray[row].Length))
    {
        jaggedArray[row][col] -= value;
    }
}

static void Add(int[][] jaggedArray, int row, int col, int value)
{
    if ((0 <= row && row < jaggedArray.Length) && (0 <= col && col < jaggedArray[row].Length))
    {
        jaggedArray[row][col] += value;
    }
}

static void ManipulateRows(int rows, int[][] jaggedArray)
{
    for (int row = 0; row < rows - 1; row++)
    {
        int[] currentRow = jaggedArray[row];
        int[] nextRow = jaggedArray[row + 1];

        if (currentRow.Length == nextRow.Length)
        {
            for (int col = 0; col < currentRow.Length; col++)
            {
                jaggedArray[row][col] *= 2;
                jaggedArray[row + 1][col] *= 2;
            }
        }
        else
        {
            for (int col = 0; col < currentRow.Length; col++)
            {
                jaggedArray[row][col] /= 2;
            }

            for (int col = 0; col < nextRow.Length; col++)
            {
                jaggedArray[row + 1][col] /= 2;
            }
        }
    }
}

static void PrintJaggedArray(int[][] jaggedArray)
{
    foreach (var item in jaggedArray)
    {
        Console.WriteLine(String.Join(' ', item));
    }
}