namespace SantaSecretHelper
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());

            List<string> goodKids = new List<string>();

            while (true)
            {
                string encryptedMessage = Console.ReadLine();

                if (encryptedMessage == "end")
                {
                    break;
                }

                StringBuilder sb = new StringBuilder();

                foreach (var symbol in encryptedMessage)
                {
                    char decryptedSymbol = (char)(symbol - key);

                    sb.Append(decryptedSymbol);
                }

                string decryptedMessage = sb.ToString();

                string namePattern = @"\@([A-Za-z]+)";

                Match nameMatch = Regex.Match(decryptedMessage, namePattern);

                if (nameMatch.Success)
                {
                    string name = nameMatch.Groups[1].Value;

                    string behaviourTypePattern = $@"{name}[^\@\-\!\:\>]+!(G)!";
                    Match behaviourTypeMatch = Regex.Match(decryptedMessage, behaviourTypePattern);

                    if (behaviourTypeMatch.Success)
                    {
                        goodKids.Add(name);
                    }
                }
            }

            foreach (var kid in goodKids)
            {
                Console.WriteLine(kid);
            }
        }
    }
}
