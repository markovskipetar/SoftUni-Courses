int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int i = 0; i < rows; i++)
{
    int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

    jaggedArray[i] = currentRow;
}

while (true)
{
    string[] input = Console.ReadLine().Split();

    string command = input[0];

    if (command == "END")
    {
        break;
    }

    int row = int.Parse(input[1]);
    int col = int.Parse(input[2]);
    int value = int.Parse(input[3]);

    bool areCoordinatesInvalid = row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length;

    if (!areCoordinatesInvalid)
    {
        if (command == "Add")
        {
            jaggedArray[row][col] += value;
        }
        else if (command == "Subtract")
        {
            jaggedArray[row][col] -= value;
        }
    }
    else
    {
        Console.WriteLine("Invalid coordinates");
    }
}

foreach (var array in jaggedArray)
{
    Console.WriteLine(String.Join(" ", array));
}