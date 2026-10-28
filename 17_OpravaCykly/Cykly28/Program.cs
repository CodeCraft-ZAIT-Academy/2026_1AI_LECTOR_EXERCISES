// Úloha 28: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   120
//   1307674368000

// 15! = 1307674368000
Console.WriteLine(Factorial(5));
Console.WriteLine(Factorial(15));

static int Factorial(int n)
{
    int result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }

    return result;
}
