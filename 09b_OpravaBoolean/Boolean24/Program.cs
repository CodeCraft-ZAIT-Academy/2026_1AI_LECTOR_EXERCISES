// Úloha 24: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   True
//   False

// True len vtedy, ak sú oba vstupy rovnaké (aj false == false).
Console.WriteLine(AreEqual(true, true));
Console.WriteLine(AreEqual(false, false));
Console.WriteLine(AreEqual(true, false));

static bool AreEqual(bool a, bool b)
{
    return a && b;
}
