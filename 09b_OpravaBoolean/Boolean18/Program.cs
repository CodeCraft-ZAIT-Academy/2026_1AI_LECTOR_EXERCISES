// Úloha 18: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   False
//   True
//   True
//   False

// XOR je true, len ak je PRÁVE JEDNA hodnota true.
Console.WriteLine(Xor(true, true));
Console.WriteLine(Xor(true, false));
Console.WriteLine(Xor(false, true));
Console.WriteLine(Xor(false, false));

static bool Xor(bool a, bool b)
{
    return a || b;
}
