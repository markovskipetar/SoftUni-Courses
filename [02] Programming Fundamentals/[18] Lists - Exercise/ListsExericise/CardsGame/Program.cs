namespace CardsGame
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> firstPlayerCards = Console.ReadLine()
                 .Split()
                 .Select(x => int.Parse(x))
                 .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
                 .Split()
                 .Select(x => int.Parse(x))
                 .ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                int firstPlayerCurrentCard = firstPlayerCards[0];
                int secondPlayerCurrentCard = secondPlayerCards[0];

                if (firstPlayerCurrentCard == secondPlayerCurrentCard)
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
                else if (firstPlayerCurrentCard > secondPlayerCurrentCard)
                {
                    firstPlayerCards.Add(firstPlayerCurrentCard);
                    firstPlayerCards.Add(secondPlayerCurrentCard);

                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
                else if(secondPlayerCurrentCard > firstPlayerCurrentCard)
                {
                    secondPlayerCards.Add(secondPlayerCurrentCard);
                    secondPlayerCards.Add(firstPlayerCurrentCard);

                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
            }

            int sum = 0;
            string winner = string.Empty;

            if (firstPlayerCards.Count == 0)
            {
                sum = secondPlayerCards.Sum();
                winner = "Second";
            }
            else
            {
                sum = firstPlayerCards.Sum();
                winner = "First";
            }

            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }
    }
}
