// ===== 16 – Bonus 4: pravdivosť v texte =====
// Zadanie z lekcie: true, ak text obsahuje "pravda" alebo "true" A ZÁROVEŇ neobsahuje "nepravda" ani "false".
// Ukáž:       metóda Contains vracia bool. Pozor: slovo "nepravda" OBSAHUJE aj slovo "pravda"!
//             Preto samotné hľadanie "pravda" nestačí, treba vylúčiť aj "nepravda".

Console.WriteLine("\"pravda\"        -> " + ContainsTruth("pravda"));
Console.WriteLine("\"true story\"    -> " + ContainsTruth("true story"));
Console.WriteLine("\"nepravda\"      -> " + ContainsTruth("nepravda"));
Console.WriteLine("\"false\"         -> " + ContainsTruth("false"));
Console.WriteLine("\"true or false\" -> " + ContainsTruth("true or false"));
Console.WriteLine("\"ahoj\"          -> " + ContainsTruth("ahoj"));

static bool ContainsTruth(string text)
{
    bool hasPositive = text.Contains("pravda") || text.Contains("true");
    bool hasNegative = text.Contains("nepravda") || text.Contains("false");

    return hasPositive && !hasNegative;
}
