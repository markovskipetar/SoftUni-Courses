using System;
using System.Linq;

namespace _03.Jedi_Galaxy
{
    class Program
    {
        private static int[,] matrix;
        private static long sum;
        
        static void Main()
        {
            int[] demensions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int m = demensions[0];
            int n = demensions[1];

            InitializeMatrix(m, n);

            sum = 0;
            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                ProcessCoordinates(command);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
        private static void ProcessCoordinates(string command)
        {
            int[] ivoCoordinates = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] evilCoordinates = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            MovePlayerEvil(evilCoordinates);
            MovePlayerIvo(ivoCoordinates);
        }
        private static bool IsInsideTheField(int row, int col)
        {
            bool isInside = row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
            return isInside;
        }
        private static void MovePlayerIvo(int[] ivoCoordinates)
        {
            int ivoRow = ivoCoordinates[0];
            int ivoCol = ivoCoordinates[1];

            while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
            {
                if (IsInsideTheField(ivoRow, ivoCol))
                {
                    sum += matrix[ivoRow, ivoCol];
                }

                ivoCol++;
                ivoRow--;
            }
        }
        private static void MovePlayerEvil(int[] evilCoordinates)
        {
            int evilRow = evilCoordinates[0];
            int evilCol = evilCoordinates[1];

            while (evilRow >= 0 && evilCol >= 0)
            {
                if (IsInsideTheField(evilRow, evilCol))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }
        }
        static void InitializeMatrix(int rows, int cols)
        {
            matrix = new int[rows, cols];

            int currentNumber = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentNumber++;
                }
            }
        }
    }
}
