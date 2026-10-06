// ===== 05 – Hraničné hodnoty =====
// Ukáž:       vždy testujeme hodnoty PRESNE NA HRANICI (12, 13, 17, 18).
// Skús zmeniť: v metóde Describe zmeň >= na > a sleduj, pri ktorých vekoch sa výsledok pokazí.

Console.WriteLine("12: " + Describe(12));
Console.WriteLine("13: " + Describe(13));
Console.WriteLine("17: " + Describe(17));
Console.WriteLine("18: " + Describe(18));

static string Describe(int age)
{
    if (age >= 18)
    {
        return "adult";
    }
    else if (age >= 13)
    {
        return "teenager";
    }
    else
    {
        return "kid";
    }
}
