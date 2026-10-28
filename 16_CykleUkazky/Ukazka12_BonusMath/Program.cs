// ===== 12 – Bonusy z lekcie: faktoriál a ciferný súčet =====
// Ukáž:       faktoriál n! = 1 * 2 * ... * n. Rastie veľmi rýchlo: int pretečie už pri 13! → použijeme long.
//             Ciferný súčet: posledná cifra je n % 10, odstránime ju n / 10.
// Skús zmeniť: Factorial(13) – a zmeň typ na int a pozri, čo sa stane.

Console.WriteLine("5!  = " + Factorial(5));       // 120
Console.WriteLine("10! = " + Factorial(10));      // 3628800
Console.WriteLine("20! = " + Factorial(20));      // 2432902008176640000

Console.WriteLine("Ciferný súčet 12345: " + DigitSum(12345));    // 15
Console.WriteLine("Ciferný súčet 9: " + DigitSum(9));            // 9
Console.WriteLine("Ciferný súčet 1000: " + DigitSum(1000));      // 1

static long Factorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }

    return result;
}

static int DigitSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;     // posledná cifra
        number /= 10;           // odstránime poslednú cifru
    }

    return sum;
}
