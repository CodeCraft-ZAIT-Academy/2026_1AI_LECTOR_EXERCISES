// Úloha 21: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   False
//   False
//   False

// True, ak text obsahuje "pravda" alebo "true" A ZÁROVEŇ neobsahuje "nepravda" ani "false".
Console.WriteLine(ContainsTruth("pravda"));
Console.WriteLine(ContainsTruth("nepravda"));
Console.WriteLine(ContainsTruth("true or false"));
Console.WriteLine(ContainsTruth("ahoj"));

static bool ContainsTruth(string text)
{
    return text.Contains("pravda") || text.Contains("true");
}
