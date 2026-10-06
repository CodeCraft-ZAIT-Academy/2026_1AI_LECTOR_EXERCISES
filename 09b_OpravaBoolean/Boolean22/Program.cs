// Úloha 22: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   False
//   False
//   True

// True, ak sú aspoň DVE z troch hodnôt true.
Console.WriteLine(AtLeastTwo(true, true, false));
Console.WriteLine(AtLeastTwo(false, false, true));
Console.WriteLine(AtLeastTwo(true, false, false));
Console.WriteLine(AtLeastTwo(false, true, true));

static bool AtLeastTwo(bool a, bool b, bool c)
{
    return a && b || c;
}
