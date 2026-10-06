// Úloha 20: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   False
//   True

// Párne číslo má po delení dvomi zvyšok 0.
Console.WriteLine(IsEven(4));
Console.WriteLine(IsEven(7));
Console.WriteLine(IsEven(0));

static bool IsEven(int n)
{
    return n % 2 == 1;
}
