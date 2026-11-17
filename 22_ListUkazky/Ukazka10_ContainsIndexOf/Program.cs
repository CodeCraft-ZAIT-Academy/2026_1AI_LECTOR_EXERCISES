// ===== LIST 10 – Contains a IndexOf =====
// Pojmy: Contains, IndexOf, hodnota -1 = nenájdené, if
// Skús zmeniť:
//   1. Hľadaj meno, ktoré v zozname je, aj také, ktoré tam nie je.
//   2. Hľadaj "anna" (malé a). Nájde sa? (Veľké a malé písmená sa rozlišujú.)
//   3. Vypíš index mena "Boris".

List<string> names = new List<string> { "Anna", "Boris", "Cyril" };

if (names.Contains("Boris"))
{
    Console.WriteLine("Boris je v zozname");
}

if (!names.Contains("Dana"))
{
    Console.WriteLine("Dana v zozname nie je");
}

Console.WriteLine("Index Cyrila: " + names.IndexOf("Cyril"));
Console.WriteLine("Index Dany: " + names.IndexOf("Dana"));

Console.WriteLine("Contains(\"anna\"): " + names.Contains("anna"));
