namespace TakeSkipRope
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;

    public class Program
    {
        static void Main()
        {
            string encryptedMessage = Console.ReadLine();

            List<char> symbols = new List<char>();
            List<int> takeNumbers = new List<int>();
            List<int> skipNumbers = new List<int>();

            DivideEncryptedMessage(encryptedMessage, symbols, takeNumbers, skipNumbers);

            string message = new string(symbols.ToArray());

            string decryptedMessage = GetDecryptedMessage(message, takeNumbers, skipNumbers);

            Console.WriteLine(decryptedMessage);
        }

        static string GetDecryptedMessage(string message, List<int> takeNumbers, List<int> skipNumbers)
        {
            string decryptedMessage = String.Empty;

            int index = 0;

            for (int i = 0; i < takeNumbers.Count; i++)
            {
                int symbolsToTake = takeNumbers[i];
                int symbolsToSkip = skipNumbers[i];

                if (index + symbolsToTake > message.Length)
                {
                    int diff = message.Length - index;
                    string currentText = message.Substring(index, diff);
                    decryptedMessage += currentText;
                }
                else
                {
                    string currentText = message.Substring(index, symbolsToTake);
                    decryptedMessage += currentText;
                    index += symbolsToSkip + symbolsToTake;
                }
            }

            return decryptedMessage;
        }

        static void DivideEncryptedMessage(string encryptedMessage, List<char> textSymbols, List<int> takeNumbers, List<int> skipNumbers)
        {
            bool isIndexEven = true;

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char currentSymbol = encryptedMessage[i];

                if (48 <= currentSymbol && currentSymbol <= 57)
                {
                    int number = int.Parse(currentSymbol.ToString());

                    if (isIndexEven)
                    {
                        takeNumbers.Add(number);
                        isIndexEven = false;
                    }
                    else
                    {
                        skipNumbers.Add(number);
                        isIndexEven = true;
                    }
                }
                else
                {
                    textSymbols.Add(currentSymbol);
                }
            }
        }
    }
}
