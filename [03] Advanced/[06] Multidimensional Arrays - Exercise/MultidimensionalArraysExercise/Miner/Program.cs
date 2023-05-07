int size = int.Parse(Console.ReadLine());
string[] directions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

string[,] matrix = new string[size, size];

int coalsCount = 0;

int currentRow = 0;
int currentCol = 0;

int endRow = 0;
int endCol = 0;

for (int row = 0; row < size; row++)
{
    string[] rowValues = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = rowValues[col];

        if (rowValues[col] == "c")
        {
            coalsCount++;
        }

        if (rowValues[col] == "s")
        {
            currentRow = row;
            currentCol = col;
        }

        if (rowValues[col] == "e")
        {
            endRow = row;
            endCol = col;
        }
    }
}

bool isEnd = false;
bool allCoalsFound = false;

for (int i = 0; i < directions.Length; i++)
{
    string currentDirection = directions[i];

    bool isValid = false;

    if (currentDirection == "up")
    {
        if (currentRow - 1 >= 0)
        {
            currentRow--;
            isValid = true;
        }
    }
    else if (currentDirection == "down")
    {
        if (currentRow + 1 < size)
        {
            currentRow++;
            isValid = true;
        }
    }
    else if (currentDirection == "right")
    {
        if (currentCol + 1 < size)
        {
            currentCol++;
            isValid = true;
        }
    }
    else if (currentDirection == "left")
    {
        if (currentCol - 1 >= 0)
        {
            currentCol--;
            isValid = true;
        }
    }

    if (isValid)
    {
        if (matrix[currentRow, currentCol] == "c")
        {
            coalsCount--;

            if (coalsCount == 0)
            {
                break;
            }

            matrix[currentRow, currentCol] = "*";
        }
        else if (matrix[currentRow, currentCol] == "e")
        {
            isEnd = true;
            break;
        }
    }
}

if (isEnd)
{
    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
}
else
{
    if (coalsCount == 0)
    {
        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
    }
    else
    {
        Console.WriteLine($"{coalsCount} coals left. ({currentRow}, {currentCol})");
    }
}
