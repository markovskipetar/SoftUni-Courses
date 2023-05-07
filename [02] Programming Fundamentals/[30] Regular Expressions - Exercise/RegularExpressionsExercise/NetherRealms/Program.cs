namespace NetherRealms
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            string[] input = Regex.Split(Console.ReadLine(), @" *, *");

            Regex name = new Regex(@"[^0-9\+\-\*\/.]");
            Regex numbersPattern = new Regex(@"-?[0-9]+\.?[0-9]*");
            Regex signPatter = new Regex(@"[*\/]");

            List<string> demons = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string demon = input[i];

                MatchCollection nameMatch = name.Matches(demon);

                string demonName = string.Empty;
                int demonHealth = 0;

                foreach (Match symbol in nameMatch)
                {
                    demonName += symbol.Value;
                    demonHealth += symbol.Value[0];
                }

                double demonDamage = 0;

                MatchCollection numbers = numbersPattern.Matches(demon);

                foreach (Match number in numbers)
                {
                    demonDamage += double.Parse(number.Value);
                }

                MatchCollection signs = signPatter.Matches(demon);

                foreach (Match sign in signs)
                {
                    if (sign.Value == "*")
                    {
                        demonDamage *= 2;
                    }
                    else if (sign.Value == "/")
                    {
                        demonDamage /= 2;
                    }
                }

                string demonInfo = $"{demon} - {demonHealth} health, {demonDamage:f2} damage";
                demons.Add(demonInfo);
            }

            demons.Sort();

            foreach (var demon in demons)
            {
                Console.WriteLine(demon);
            }
        }
    }
}
