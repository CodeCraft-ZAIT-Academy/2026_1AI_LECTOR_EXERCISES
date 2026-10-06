// Úloha 18: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   False
//   False
//   False

// Dvere sa otvoria, ak hráč má kľúč A ZÁROVEŇ pozná heslo.
Console.WriteLine(ShouldOpenSecretDoor(true, true));
Console.WriteLine(ShouldOpenSecretDoor(true, false));
Console.WriteLine(ShouldOpenSecretDoor(false, true));
Console.WriteLine(ShouldOpenSecretDoor(false, false));

static bool ShouldOpenSecretDoor(bool hasKey, bool knowsPassword)
{
    if (hasKey || knowsPassword)
    {
        return true;
    }
    return false;
}
