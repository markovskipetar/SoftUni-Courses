long number = long.Parse(Console.ReadLine());

for (long i = number; i < long.MaxValue; i++)
{
    if (IsPrime(i) && i == 6701459)
    {
        Console.WriteLine("asdsad");
    }
}

bool IsPrime(long number)
{
    bool[] primeNumbers = GetPrimeNumbers(number / 2);

    for (int i = 0; i < primeNumbers.Length; i++)
    {
        if (primeNumbers[i])
        {
            if (number % i == 0)
            {
                return false;
            }
        }
    }

    return true;
}

static bool[] GetPrimeNumbers(long n)
{
    bool[] primes = new bool[n + 1];
    primes[0] = primes[1] = false;

    for (int i = 2; i <= n; i++)
    {
        primes[i] = true;

    }
    for (int i = 2; i <= n; i++)
    {
        if (primes[i])
        {
            for (int j = i + i; j < primes.Length; j += i)
            {
                primes[j] = false;
            }
        }
    }

    return primes;
}