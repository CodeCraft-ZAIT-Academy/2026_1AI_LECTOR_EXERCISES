// ===== 13 – Metódy vracajúce bool (GameRules z lekcie) =====
// Ukáž:       metóda vráti true/false podľa podmienky. Dlhá a krátka forma robia to isté.
// Skús zmeniť: argumenty pri volaní. Aké hodnoty vrátia metódy?

Console.WriteLine("CanPlayerEnterGame(\"Anna\", 20): " + CanPlayerEnterGame("Anna", 20));      // True
Console.WriteLine("CanPlayerEnterGame(\"Anna\", 14): " + CanPlayerEnterGame("Anna", 14));      // False
Console.WriteLine("CanPlayerEnterGame(\"\", 20):     " + CanPlayerEnterGame("", 20));          // False
Console.WriteLine("IsGameOver(50): " + IsGameOver(50));                                         // False
Console.WriteLine("IsGameOver(0):  " + IsGameOver(0));                                          // True
Console.WriteLine("ShouldOpenSecretDoor(true, true):  " + ShouldOpenSecretDoor(true, true));    // True
Console.WriteLine("ShouldOpenSecretDoor(true, false): " + ShouldOpenSecretDoor(true, false));   // False

// Dlhá forma – s if / else
static bool CanPlayerEnterGame(string playerName, int playerAge)
{
    if (playerAge >= 15 && playerName != "")
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Krátka forma – podmienka je priamo návratová hodnota
static bool IsGameOver(int playerHealth)
{
    return playerHealth <= 0;
}

static bool ShouldOpenSecretDoor(bool hasKey, bool knowsPassword)
{
    return hasKey && knowsPassword;
}
