namespace MatchFullName
{
    using System.Text.RegularExpressions;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string text = Console.ReadLine() ;

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
