int size = int.Parse(Console.ReadLine());

List<int[]> indexes = new List<int[]>();
char[,] matrix = ReadMatrix(size, indexes);

int counter = 0;

for (int i = 0; i < indexes.Count; i++)
{
    int[] currentKnight = indexes[i];

    int tempCounter = 0;

    int row = currentKnight[0];
    int col = currentKnight[1];

    int rowToRemove = 0;
    int colToRemove = 0;

    int leftDownRow = row + 1;
    int leftDownCol = col - 2;
    bool isLeftDownInRange = (0 <= leftDownRow && leftDownRow < size) && (0 <= leftDownCol && leftDownCol < size);

    int downLeftRow = row + 2;
    int downLeftCol = col - 1;
    bool isDownLeftInRange = (0 <= downLeftRow && downLeftRow < size) && (0 <= downLeftCol && downLeftCol < size);

    int downRightRow = row + 2;
    int downRightCol = col + 1;
    bool isDownRightInRange = (0 <= downRightRow && downRightRow < size) && (0 <= downRightCol && downRightCol < size);

    int rightDownRow = row + 1;
    int rightDownCol = col + 2;
    bool isRightDownInRange = (0 <= rightDownRow && rightDownRow < size) && (0 <= rightDownCol && rightDownCol < size);

    int leftUpRow = row - 1;
    int leftUpCol = col - 2;
    bool isLeftUpInRange = (0 <= leftUpRow && leftUpRow < size) && (0 <= leftUpCol && leftUpCol < size);

    int upLeftRow = row - 2;
    int upLeftCol = col - 1;
    bool isUpLeftInRange = (0 <= upLeftRow && upLeftRow < size) && (0 <= upLeftCol && upLeftCol < size);

    int rightUpRow = row - 1;
    int rightUpCol = col + 2;
    bool isRightUpInRange = (0 <= rightUpRow && rightUpRow < size) && (0 <= rightUpCol && rightUpCol < size);

    int upRightRow = row - 2;
    int upRightCol = col + 1;
    bool isUpRightInRange = (0 <= upRightRow && upRightRow < size) && (0 <= upRightCol && upRightCol < size);

    if (isLeftDownInRange && matrix[leftDownRow, leftDownCol] == 'K')
    {
        rowToRemove = leftDownRow;
        colToRemove = leftDownCol;

        tempCounter++;
    }

    if (isDownLeftInRange && matrix[downLeftRow, downLeftCol] == 'K')
    {
        rowToRemove = downLeftRow;
        colToRemove = downLeftCol;

        tempCounter++;
    }

    if (isDownRightInRange && matrix[downRightRow, downRightCol] == 'K')
    {
        rowToRemove = downRightRow;
        colToRemove = downRightCol;

        tempCounter++;
    }

    if (isRightDownInRange && matrix[rightDownRow, rightDownCol] == 'K')
    {
        rowToRemove = rightDownRow;
        colToRemove = rightDownCol;

        tempCounter++;
    }

    if (isLeftUpInRange && matrix[leftUpRow, leftUpCol] == 'K')
    {
        rowToRemove = leftUpRow;
        colToRemove = leftUpCol;

        tempCounter++;
    }

    if (isUpLeftInRange && matrix[upLeftRow, upLeftCol] == 'K')
    {
        rowToRemove = upLeftRow;
        colToRemove = upLeftCol;

        tempCounter++;
    }

    if (isRightUpInRange && matrix[rightUpRow, rightUpCol] == 'K')
    {
        rowToRemove = rightUpRow;
        colToRemove = rightUpCol;

        tempCounter++;
    }

    if (isUpRightInRange && matrix[upRightRow, upRightCol] == 'K')
    {
        rowToRemove = upRightRow;
        colToRemove = upRightCol;

        tempCounter++;
    }

    if (tempCounter > 1)
    {
        indexes.RemoveAll(x => x[0] == row && x[1] == col);

        matrix[row, col] = '0';
        i--;

        counter++;
    }
    else if (tempCounter == 1)
    {
        indexes.RemoveAll(x => x[0] == rowToRemove && x[1] == colToRemove);

        matrix[rowToRemove, colToRemove] = '0';
        i--;

        counter++;
    }

    tempCounter = 0;
}

Console.WriteLine(counter);

static char[,] ReadMatrix(int size, List<int[]> indexes)
{
    char[,] matrix = new char[size, size];

    for (int row = 0; row < size; row++)
    {
        string rowValues = Console.ReadLine();

        for (int col = 0; col < size; col++)
        {
            if (rowValues[col] == 'K')
            {
                indexes.Add(new int[] { row, col });
            }

            matrix[row, col] = rowValues[col];
        }
    }

    return matrix;
}

static void PrintMatrix(char[,] matrix)
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