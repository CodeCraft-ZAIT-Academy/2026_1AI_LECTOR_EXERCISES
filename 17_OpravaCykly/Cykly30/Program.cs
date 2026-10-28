// Úloha 30: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   False
//   True

// 7 a 2 sú prvočísla, 9 nie je.
Console.WriteLine(IsPrime(7));
Console.WriteLine(IsPrime(9));
Console.WriteLine(IsPrime(2));

static bool IsPrime(int n)
{
    if (n < 2)
    {
        return false;
    }

    for (int divisor = 2; divisor <= n; divisor++)
    {
        if (n % divisor == 0)
        {
            return false;
        }
    }

    return true;
}
