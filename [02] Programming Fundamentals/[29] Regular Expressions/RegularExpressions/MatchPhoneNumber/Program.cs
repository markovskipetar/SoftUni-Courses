namespace MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"\+359(\s|-)2\1\d{3}\1\d{4}\b");

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine(String.Join(", ", matches));
        }
    }
}
