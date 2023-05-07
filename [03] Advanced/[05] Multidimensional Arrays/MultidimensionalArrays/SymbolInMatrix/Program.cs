int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];

for (int row = 0; row < size; row++)
{
    string currentRow = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = currentRow[col];
    }
}

char symbolToSearch = char.Parse(Console.ReadLine());

int rowToPrint = 0;
int colToPrint = 0;
bool isFound = false;

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] == symbolToSearch)
        {
            rowToPrint = row;
            colToPrint = col;
            isFound = true;
            break;
        }
    }

    if (isFound)
    {
        break;
    }
}

if (isFound)
{
    Console.WriteLine($"({rowToPrint}, {colToPrint})");
}
else
{
    Console.WriteLine($"{symbolToSearch} does not occur in the matrix");
}