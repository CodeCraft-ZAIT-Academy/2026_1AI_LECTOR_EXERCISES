// Úloha 17: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   False
//   True
//   False

// Číslo je v intervale 10 až 20 vrátane.
Console.WriteLine(IsInRange(5));
Console.WriteLine(IsInRange(15));
Console.WriteLine(IsInRange(25));

static bool IsInRange(int x)
{
    return x >= 10 || x <= 20;
}
