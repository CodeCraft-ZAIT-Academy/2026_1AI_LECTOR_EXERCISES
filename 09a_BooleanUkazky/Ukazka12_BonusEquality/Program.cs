// ===== 12 – Bonus 1: rovnosť dvoch boolov =====
// Zadanie z lekcie: vráť true len vtedy, ak sú oba vstupy rovnaké.
// Ukáž:       == funguje aj pre bool. Alternatíva (dlhšia): (a && b) || (!a && !b).

Console.WriteLine("AreEqual(true, true)   = " + AreEqual(true, true));
Console.WriteLine("AreEqual(true, false)  = " + AreEqual(true, false));
Console.WriteLine("AreEqual(false, true)  = " + AreEqual(false, true));
Console.WriteLine("AreEqual(false, false) = " + AreEqual(false, false));

static bool AreEqual(bool a, bool b)
{
    return a == b;
}
