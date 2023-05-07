using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine()); // въвеждаме броя на числат, които ще прочитаме
            int sum = 0; // декларираме променлива, в която ще натрупваме сумата

            for (int i = 0; i < numbersCount; i++) // въртим цикъл от 0 до броя на числата
            {
                int currentNumber = int.Parse(Console.ReadLine()); // четем текущото число

                sum += currentNumber; // добавяме го към променливата sum
            }

            Console.WriteLine(sum); // печатаме sum
        }
    }
}
