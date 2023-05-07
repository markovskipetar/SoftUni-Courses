using System;
using System.Globalization;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = String.Empty;

            switch (country)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;

                default:
                    language = "unknown";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}
