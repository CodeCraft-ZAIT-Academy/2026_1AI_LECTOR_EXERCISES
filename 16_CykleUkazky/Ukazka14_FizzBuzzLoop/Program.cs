// ===== 14 – FizzBuzz a prvočísla =====
// Ukáž:       FizzBuzz z lekcie Metódy (018) – teraz ho zavoláme v cykle pre čísla 1 až 15.
//             Prvočísla: číslo n je prvočíslo, ak nie je deliteľné žiadnym číslom od 2 po odmocninu z n.
// Skús zmeniť: horné hranice cyklov (15, 30).

for (int n = 1; n <= 15; n++)
{
    Console.WriteLine(FizzBuzz(n));
}

Console.WriteLine();
Console.WriteLine("Prvočísla do 30:");
for (int n = 2; n <= 30; n++)
{
    if (IsPrime(n))
    {
        Console.Write(n + " ");
    }
}
Console.WriteLine();

static string FizzBuzz(int number)
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        return "FizzBuzz";
    }
    else if (number % 3 == 0)
    {
        return "Fizz";
    }
    else if (number % 5 == 0)
    {
        return "Buzz";
    }
    else
    {
        return number.ToString();
    }
}

static bool IsPrime(int n)
{
    if (n < 2)
    {
        return false;
    }

    for (int divisor = 2; divisor * divisor <= n; divisor++)
    {
        if (n % divisor == 0)
        {
            return false;       // našli sme deliteľa, ďalej nehľadáme
        }
    }

    return true;
}
