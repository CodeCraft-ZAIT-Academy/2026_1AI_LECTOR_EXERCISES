// Úloha 17: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   False
//   False
//   True
//   True

// Hra je skončená, ak je zdravie menšie alebo rovné nule.
Console.WriteLine(IsGameOver(100));
Console.WriteLine(IsGameOver(1));
Console.WriteLine(IsGameOver(0));
Console.WriteLine(IsGameOver(-5));

static bool IsGameOver(int playerHealth)
{
    if (playerHealth < 0)
    {
        return true;
    }
    return false;
}
