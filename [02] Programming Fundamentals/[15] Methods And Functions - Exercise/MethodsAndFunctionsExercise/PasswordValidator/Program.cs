using System;
using System.Runtime.ConstrainedExecution;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLengthFromSixToTenDigits = GetLength(password);
            bool isContainingOnlyLettersAndDigits = IsContainingRequiredSymbols(password);
            bool isAtLeastTwoDigitsCoun = GetCountOfDigits(password);

            if (isLengthFromSixToTenDigits && isContainingOnlyLettersAndDigits && isAtLeastTwoDigitsCoun)
            {
                Console.WriteLine("Password is valid");
            }
            else 
            {
                if (!isLengthFromSixToTenDigits)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters ");
                }

                if (!isContainingOnlyLettersAndDigits)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!isAtLeastTwoDigitsCoun)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static bool GetLength(string password)
        {
            int passwordLength = password.Length;

            if (6 <= passwordLength && passwordLength <= 10)
            {
                return true;
            }

            return false;
        }

        static bool IsContainingRequiredSymbols(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentSymbol = password[i];

                if (!char.IsLetterOrDigit(currentSymbol))
                {
                    return false;
                }
            }

            return true;
        }

        static bool GetCountOfDigits(string password)
        {
            int digitsCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currentSymbol = password[i];

                if (char.IsDigit(currentSymbol))
                {
                    digitsCounter++;
                }

                if (digitsCounter == 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
