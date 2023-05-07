namespace WinningTicket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"\@{6,10}|\#{6,10}|\${6,10}|\^{6,10}");

            string[] ticketsInput = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < ticketsInput.Length; i++)
            {
                string ticket = ticketsInput[i];

                if (ticket.Length == 20)
                {
                    string firstPart = ticket.Substring(0, 10);
                    string secondPart = ticket.Substring(10, 10);

                    Match firstMatch = regex.Match(firstPart);
                    Match secondMatch = regex.Match(secondPart);

                    if (!(firstMatch.Success && secondMatch.Success))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                        continue;
                    }

                    string firstPartMatch = regex.Match(firstPart).Value;
                    string secondPartMatch = regex.Match(secondPart).Value;

                    int length = Math.Min(firstPartMatch.Length, secondPartMatch.Length);

                    if (firstPartMatch == secondPartMatch && firstPartMatch.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{firstPartMatch[0]} Jackpot!");
                    }
                    else
                    {
                        if ((firstPartMatch[0] == secondPartMatch[0]) && (firstPartMatch.Length >= 6 && secondPartMatch.Length >= 6))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {length}{firstPartMatch[0]}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
