// Úloha 16: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   False
//   False
//   False

// Hráč smie vstúpiť, ak má aspoň 15 rokov A ZÁROVEŇ neprázdne meno.
Console.WriteLine(CanPlayerEnterGame("Anna", 20));
Console.WriteLine(CanPlayerEnterGame("Anna", 14));
Console.WriteLine(CanPlayerEnterGame("", 20));
Console.WriteLine(CanPlayerEnterGame("", 10));

static bool CanPlayerEnterGame(string playerName, int playerAge)
{
    if (playerAge >= 15 || playerName != "")
    {
        return true;
    }
    return false;
}
